using Microsoft.EntityFrameworkCore;
using movielandia_.net_api.DAL.Interfaces;
using movielandia_.net_api.Data;
using movielandia_.net_api.DTOs;
using movielandia_.net_api.Models;

namespace movielandia_.net_api.DAL.Implementations
{
    public class MovieDAL : GenericDAL<Movie>, IMovieDAL
    {
        #region Fields
        private new readonly ApplicationDbContext _context;
        #endregion

        #region Constructor
        public MovieDAL(ApplicationDbContext context)
            : base(context)
        {
            _context = context;
        }
        #endregion

        #region Get Methods
        public async Task<IEnumerable<Movie>> GetAllMoviesAsync()
        {
            return await _context.Movie.ToListAsync();
        }

        public async Task<IEnumerable<Movie>> GetMoviesForHomePageAsync()
        {
            return await _context.Movie.OrderByDescending(m => m.DateAired).Take(30).ToListAsync();
        }

        public async Task<(IEnumerable<Movie> Movies, int TotalCount)> GetMoviesWithFiltersAsync(
            MovieFilterDTO filter
        )
        {
            var query = _context.Movie.AsQueryable();

            if (!string.IsNullOrWhiteSpace(filter.Title))
            {
                query = query.Where(m => m.Title.Contains(filter.Title));
            }

            if (
                filter.FilterValue != null
                && !string.IsNullOrWhiteSpace(filter.FilterNameString)
                && filter.FilterOperatorString.HasValue
            )
            {
                var property = typeof(Movie).GetProperty(filter.FilterNameString);

                if (property != null)
                {
                    object filterValue = Convert.ChangeType(
                        filter.FilterValue,
                        property.PropertyType
                    );

                    switch (filter.FilterOperatorString)
                    {
                        case FilterOperator.Contains:
                            if (property.PropertyType == typeof(string))
                            {
                                var searchValue =
                                    filterValue != null ? filterValue.ToString() : string.Empty;

                                query = query.Where(m =>
                                    EF.Property<string>(m, filter.FilterNameString)
                                        .Contains(searchValue ?? string.Empty)
                                );
                            }

                            break;
                        case FilterOperator.Equal:
                            query = query.Where(m =>
                                EF.Property<object>(m, filter.FilterNameString).Equals(filterValue)
                            );

                            break;
                        case FilterOperator.GreaterThan:
                            if (property.PropertyType == typeof(int))
                            {
                                int value = Convert.ToInt32(filterValue);

                                query = query.Where(m =>
                                    EF.Property<int>(m, filter.FilterNameString) > value
                                );
                            }
                            else if (property.PropertyType == typeof(float))
                            {
                                float value = Convert.ToSingle(filterValue);

                                query = query.Where(m =>
                                    EF.Property<float>(m, filter.FilterNameString) > value
                                );
                            }

                            break;
                        case FilterOperator.LessThan:
                            if (property.PropertyType == typeof(int))
                            {
                                int value = Convert.ToInt32(filterValue);

                                query = query.Where(m =>
                                    EF.Property<int>(m, filter.FilterNameString) < value
                                );
                            }
                            else if (property.PropertyType == typeof(float))
                            {
                                float value = Convert.ToSingle(filterValue);

                                query = query.Where(m =>
                                    EF.Property<float>(m, filter.FilterNameString) < value
                                );
                            }

                            break;
                    }
                }
            }

            if (!string.IsNullOrWhiteSpace(filter.SortBy))
            {
                var property = typeof(Movie).GetProperty(filter.SortBy);

                if (property != null)
                {
                    string direction = filter.AscOrDesc?.ToLower() ?? "asc";
                    string methodName = direction == "desc" ? "OrderByDescending" : "OrderBy";

                    var orderBy = typeof(Queryable)
                        .GetMethods()
                        .First(m => m.Name == methodName && m.GetParameters().Length == 2)
                        .MakeGenericMethod(typeof(Movie), property.PropertyType);

                    var result = orderBy.Invoke(
                        null,
                        [query, GetLambdaExpression<Movie>(filter.SortBy)]
                    );

                    query = result as IQueryable<Movie> ?? query;
                }
                else
                {
                    query =
                        filter.AscOrDesc?.ToLower() == "desc"
                            ? query.OrderByDescending(m => m.Title)
                            : query.OrderBy(m => m.Title);
                }
            }
            else
            {
                query = query.OrderBy(m => m.Title);
            }

            int totalCount = await query.CountAsync();

            var movies = await query
                .Skip((filter.Page - 1) * filter.PerPage)
                .Take(filter.PerPage)
                .ToListAsync();

            return (movies, totalCount);
        }

        public async Task<Movie> GetMovieByIdWithDetailsAsync(
            int id,
            MovieQueryParameters parameters
        )
        {
            var skip = (parameters.ReviewsPage ?? 0) * 5;
            var take = 5;

            var reviewOrderBy = parameters.ReviewsSortBy ?? "CreatedAt";
            var reviewOrderDir = parameters.ReviewsAscOrDesc?.ToLower() ?? "desc";

            var movie = await _context
                .Movie.Include(m => m.Genres)
                .ThenInclude(mg => mg.Genre)
                .Include(m =>
                    m.Cast.OrderBy(c => c.Id).Skip((parameters.CastPage ?? 0) * 5).Take(5)
                )
                .ThenInclude(cm => cm.Actor)
                .Include(m =>
                    m.Crew.OrderBy(c => c.Id).Skip((parameters.CrewPage ?? 0) * 5).Take(5)
                )
                .ThenInclude(cm => cm.Crew)
                .Include(m => m.Reviews)
                .ThenInclude(r => r.User)
                .Include(m => m.Reviews)
                .ThenInclude(r => r.Upvotes)
                .ThenInclude(u => u.User)
                .Include(m => m.Reviews)
                .ThenInclude(r => r.Downvotes)
                .ThenInclude(d => d.User)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (movie != null)
            {
                var reviewsQuery = movie.Reviews.AsQueryable();

                if (reviewOrderBy.Equals("CreatedAt", StringComparison.OrdinalIgnoreCase))
                {
                    reviewsQuery =
                        reviewOrderDir == "asc"
                            ? reviewsQuery.OrderBy(r => r.CreatedAt)
                            : reviewsQuery.OrderByDescending(r => r.CreatedAt);
                }
                else if (reviewOrderBy.Equals("Rating", StringComparison.OrdinalIgnoreCase))
                {
                    reviewsQuery =
                        reviewOrderDir == "asc"
                            ? reviewsQuery.OrderBy(r => r.Rating)
                            : reviewsQuery.OrderByDescending(r => r.Rating);
                }

                movie.Reviews = reviewsQuery.Skip(skip).Take(take).ToList();
            }

            return movie ?? throw new KeyNotFoundException($"Movie with ID '{id}' was not found.");
        }

        public async Task<Movie> GetMovieByTitleWithDetailsAsync(
            string title,
            MovieQueryParameters parameters
        )
        {
            var processedTitle = title.Replace("-", " ");
            var skip = (parameters.ReviewsPage ?? 0) * 5;
            var take = 5;
            var reviewOrderBy = parameters.ReviewsSortBy ?? "CreatedAt";
            var reviewOrderDir = parameters.ReviewsAscOrDesc?.ToLower() ?? "desc";

            var movie = await _context
                .Movie.Include(m => m.Genres)
                .ThenInclude(mg => mg.Genre)
                .Include(m => m.Cast)
                .ThenInclude(cm => cm.Actor)
                .Include(m => m.Crew)
                .ThenInclude(cm => cm.Crew)
                .Include(m => m.Reviews)
                .ThenInclude(r => r.User)
                .Include(m => m.Reviews)
                .ThenInclude(r => r.Upvotes)
                .ThenInclude(u => u.User)
                .Include(m => m.Reviews)
                .ThenInclude(r => r.Downvotes)
                .ThenInclude(d => d.User)
                .FirstOrDefaultAsync(m => m.Title == processedTitle);

            if (movie != null)
            {
                var reviewsQuery = movie.Reviews.AsQueryable();

                if (reviewOrderBy.Equals("CreatedAt", StringComparison.OrdinalIgnoreCase))
                {
                    reviewsQuery =
                        reviewOrderDir == "asc"
                            ? reviewsQuery.OrderBy(r => r.CreatedAt)
                            : reviewsQuery.OrderByDescending(r => r.CreatedAt);
                }
                else if (reviewOrderBy.Equals("Rating", StringComparison.OrdinalIgnoreCase))
                {
                    reviewsQuery =
                        reviewOrderDir == "asc"
                            ? reviewsQuery.OrderBy(r => r.Rating)
                            : reviewsQuery.OrderByDescending(r => r.Rating);
                }

                movie.Reviews = reviewsQuery.Skip(skip).Take(take).ToList();
            }

            return movie
                ?? throw new KeyNotFoundException(
                    $"Movie with title '{processedTitle}' was not found."
                );
        }

        public async Task<IEnumerable<Movie>> GetLatestMoviesAsync(
            int? userId = null,
            int count = 6
        )
        {
            return await _context
                .Movie.OrderByDescending(m => m.DateAired)
                .Take(count)
                .ToListAsync();
        }

        public async Task<(IEnumerable<Movie> Movies, int TotalCount)> GetRelatedMoviesAsync(
            int id,
            int? userId,
            int page,
            int perPage
        )
        {
            var movie = await _context
                .Movie.Include(m => m.Genres)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (movie == null)
            {
                return (new List<Movie>(), 0);
            }

            var genreIds = movie.Genres.Select(mg => mg.GenreId).ToList();

            if (!genreIds.Any())
            {
                return (new List<Movie>(), 0);
            }

            var relatedMovieIds = await _context
                .MovieGenre.Where(mg => genreIds.Contains(mg.GenreId) && mg.MovieId != id)
                .Select(mg => mg.MovieId)
                .Distinct()
                .ToListAsync();

            if (!relatedMovieIds.Any())
            {
                return (new List<Movie>(), 0);
            }

            var totalCount = relatedMovieIds.Count;
            var skip = (page - 1) * perPage;
            var pagedIds = relatedMovieIds.Skip(skip).Take(perPage).ToList();

            var relatedMovies = await _context
                .Movie.Where(m => pagedIds.Contains(m.Id))
                .ToListAsync();

            relatedMovies ??= new List<Movie>();

            return (relatedMovies, totalCount);
        }
        #endregion

        #region Search and Count Methods
        public async Task<int> GetMoviesTotalCountAsync()
        {
            return await _context.Movie.CountAsync();
        }

        public async Task<(IEnumerable<Movie> Movies, int TotalCount)> SearchMoviesByTitleAsync(
            string title,
            MovieFilterDTO filter
        )
        {
            var query = _context.Movie.Where(m => m.Title.Contains(title));

            if (!string.IsNullOrWhiteSpace(filter.SortBy))
            {
                var property = typeof(Movie).GetProperty(filter.SortBy);

                if (property != null)
                {
                    string direction = filter.AscOrDesc?.ToLower() ?? "asc";
                    string methodName = direction == "desc" ? "OrderByDescending" : "OrderBy";

                    var orderBy = typeof(Queryable)
                        .GetMethods()
                        .First(m => m.Name == methodName && m.GetParameters().Length == 2)
                        .MakeGenericMethod(typeof(Movie), property.PropertyType);

                    var result = orderBy.Invoke(
                        null,
                        [query, GetLambdaExpression<Movie>(filter.SortBy)]
                    );

                    query = result as IQueryable<Movie> ?? query;
                }
                else
                {
                    query =
                        filter.AscOrDesc?.ToLower() == "desc"
                            ? query.OrderByDescending(m => m.Title)
                            : query.OrderBy(m => m.Title);
                }
            }
            else
            {
                query = query.OrderBy(m => m.Title);
            }

            int totalCount = await query.CountAsync();

            var skip = (filter.Page - 1) * filter.PerPage;
            var movies = await query.Skip(skip).Take(filter.PerPage).ToListAsync();

            return (movies, totalCount);
        }
        #endregion

        #region Movie Status Methods
        public async Task<bool> IsMovieBookmarkedByUserAsync(int movieId, int userId)
        {
            return await _context.UserMovieFavorite.AnyAsync(f =>
                f.MovieId == movieId && f.UserId == userId
            );
        }

        public async Task<bool> IsMovieReviewedByUserAsync(int movieId, int userId)
        {
            return await _context.MovieReview.AnyAsync(r =>
                r.MovieId == movieId && r.UserId == userId
            );
        }

        public async Task<(float AverageRating, int TotalReviews)> CalculateMovieRatingAsync(
            int movieId
        )
        {
            var reviews = await _context
                .MovieReview.Where(r => r.MovieId == movieId && r.Rating.HasValue)
                .ToListAsync();

            int totalReviews = reviews.Count;

            if (totalReviews == 0)
            {
                return (0, 0);
            }

            float totalRating = reviews.Sum(r => r.Rating.GetValueOrDefault(0));
            float averageRating = totalRating / totalReviews;

            return (averageRating, totalReviews);
        }

        public async Task<
            Dictionary<int, (float AverageRating, int TotalReviews)>
        > GetMovieRatingsAsync(IEnumerable<int> movieIds)
        {
            var result = new Dictionary<int, (float AverageRating, int TotalReviews)>();

            var ratings = await _context
                .MovieReview.Where(r => movieIds.Contains(r.MovieId) && r.Rating.HasValue)
                .GroupBy(r => r.MovieId)
                .Select(g => new
                {
                    MovieId = g.Key,
                    AverageRating = g.Average(r => r.Rating.GetValueOrDefault(0)),
                    TotalReviews = g.Count(),
                })
                .ToListAsync();

            foreach (var rating in ratings)
            {
                result[rating.MovieId] = ((float)rating.AverageRating, rating.TotalReviews);
            }

            foreach (var movieId in movieIds)
            {
                if (!result.ContainsKey(movieId))
                {
                    result[movieId] = (0, 0);
                }
            }

            return result;
        }
        #endregion

        #region Helper Methods
        private static System.Linq.Expressions.Expression<Func<T, object>> GetLambdaExpression<T>(
            string propertyName
        )
        {
            var parameter = System.Linq.Expressions.Expression.Parameter(typeof(T));
            var property = System.Linq.Expressions.Expression.Property(parameter, propertyName);
            var propAsObject = System.Linq.Expressions.Expression.Convert(property, typeof(object));

            return System.Linq.Expressions.Expression.Lambda<Func<T, object>>(
                propAsObject,
                parameter
            );
        }
        #endregion
    }
}
