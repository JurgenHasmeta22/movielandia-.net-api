using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using movielandia_.net_api.Data;
using movielandia_.net_api.Models.Domain;
using movielandia_.net_api.DTOs;using movielandia_.net_api.Repositories.Interfaces;

namespace movielandia_.net_api.Repositories.Implementations
{
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        private new readonly ApplicationDbContext _context;

        public MovieRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Movie>> GetAllMoviesAsync()
        {
            return await _context.Movies.ToListAsync();
        }

        public async Task<IEnumerable<Movie>> GetMoviesForHomePageAsync()
        {
            return await _context.Movies
                .OrderByDescending(m => m.DateAired)
                .Take(30)
                .ToListAsync();
        }

        public async Task<(IEnumerable<Movie> Movies, int TotalCount)> GetMoviesWithFiltersAsync(MovieFilterDTO filter)
        {
            var query = _context.Movies.AsQueryable();

            // Apply filters
            if (!string.IsNullOrWhiteSpace(filter.Title))
            {
                query = query.Where(m => m.Title.Contains(filter.Title));
            }

            if (filter.FilterValue != null && !string.IsNullOrWhiteSpace(filter.FilterNameString) && filter.FilterOperatorString.HasValue)
            {
                var property = typeof(Movie).GetProperty(filter.FilterNameString);
                if (property != null)
                {
                    object filterValue = Convert.ChangeType(filter.FilterValue, property.PropertyType);
                    
                    switch (filter.FilterOperatorString)
                    {
                        case FilterOperator.Contains:
                            if (property.PropertyType == typeof(string))
                            {
                                query = query.Where(m => EF.Property<string>(m, filter.FilterNameString).Contains(filterValue.ToString()));
                            }
                            break;
                        case FilterOperator.Equal:
                            query = query.Where(m => EF.Property<object>(m, filter.FilterNameString).Equals(filterValue));
                            break;
                        case FilterOperator.GreaterThan:
                            // This is a simplification - would need proper handling of various types
                            if (property.PropertyType == typeof(int))
                            {
                                int value = Convert.ToInt32(filterValue);
                                query = query.Where(m => EF.Property<int>(m, filter.FilterNameString) > value);
                            }
                            else if (property.PropertyType == typeof(float))
                            {
                                float value = Convert.ToSingle(filterValue);
                                query = query.Where(m => EF.Property<float>(m, filter.FilterNameString) > value);
                            }
                            break;
                        case FilterOperator.LessThan:
                            if (property.PropertyType == typeof(int))
                            {
                                int value = Convert.ToInt32(filterValue);
                                query = query.Where(m => EF.Property<int>(m, filter.FilterNameString) < value);
                            }
                            else if (property.PropertyType == typeof(float))
                            {
                                float value = Convert.ToSingle(filterValue);
                                query = query.Where(m => EF.Property<float>(m, filter.FilterNameString) < value);
                            }
                            break;
                    }
                }
            }

            // Apply sorting
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

                    query = (IQueryable<Movie>)orderBy.Invoke(
                        null,
                        new object[] { query, GetLambdaExpression<Movie>(filter.SortBy) }
                    );
                }
                else
                {
                    // Default to ordering by title if property not found
                    query = filter.AscOrDesc?.ToLower() == "desc" 
                        ? query.OrderByDescending(m => m.Title) 
                        : query.OrderBy(m => m.Title);
                }
            }
            else
            {
                // Default ordering
                query = query.OrderBy(m => m.Title);
            }

            // Count total before pagination
            int totalCount = await query.CountAsync();

            // Apply pagination
            var movies = await query
                .Skip((filter.Page - 1) * filter.PerPage)
                .Take(filter.PerPage)
                .ToListAsync();

            return (movies, totalCount);
        }

        public async Task<Movie> GetMovieByIdWithDetailsAsync(int id, MovieQueryParameters parameters)
        {
            var skip = (parameters.ReviewsPage ?? 0) * 5;
            var take = 5;

            // Determine review ordering
            var reviewOrderBy = parameters.ReviewsSortBy ?? "CreatedAt";
            var reviewOrderDir = parameters.ReviewsAscOrDesc?.ToLower() ?? "desc";

            var movie = await _context.Movies
                .Include(m => m.Genres)
                    .ThenInclude(mg => mg.Genre)
                .Include(m => m.Cast.OrderBy(c => c.Id)
                    .Skip((parameters.CastPage ?? 0) * 5).Take(5))
                    .ThenInclude(cm => cm.Actor)
                .Include(m => m.Crew.OrderBy(c => c.Id)
                    .Skip((parameters.CrewPage ?? 0) * 5).Take(5))
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

            // Apply ordering and pagination to reviews after fetching
            if (movie != null)
            {
                var reviewsQuery = movie.Reviews.AsQueryable();
                
                // Apply sorting to the reviews
                if (reviewOrderBy.Equals("CreatedAt", StringComparison.OrdinalIgnoreCase))
                {
                    reviewsQuery = reviewOrderDir == "asc" 
                        ? reviewsQuery.OrderBy(r => r.CreatedAt) 
                        : reviewsQuery.OrderByDescending(r => r.CreatedAt);
                }
                else if (reviewOrderBy.Equals("Rating", StringComparison.OrdinalIgnoreCase))
                {
                    reviewsQuery = reviewOrderDir == "asc" 
                        ? reviewsQuery.OrderBy(r => r.Rating) 
                        : reviewsQuery.OrderByDescending(r => r.Rating);
                }
                
                // Apply pagination
                movie.Reviews = reviewsQuery
                    .Skip(skip)
                    .Take(take)
                    .ToList();
            }
            
            return movie;
        }

        public async Task<Movie> GetMovieByTitleWithDetailsAsync(string title, MovieQueryParameters parameters)
        {
            // Process title if needed (e.g., replace hyphens with spaces)
            var processedTitle = title.Replace("-", " ");
            
            var skip = (parameters.ReviewsPage ?? 0) * 5;
            var take = 5;

            // Determine review ordering
            var reviewOrderBy = parameters.ReviewsSortBy ?? "CreatedAt";
            var reviewOrderDir = parameters.ReviewsAscOrDesc?.ToLower() ?? "desc";

            var movie = await _context.Movies
                .Include(m => m.Genres)
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

            // Apply ordering and pagination to reviews after fetching
            if (movie != null)
            {
                var reviewsQuery = movie.Reviews.AsQueryable();
                
                // Apply sorting to the reviews
                if (reviewOrderBy.Equals("CreatedAt", StringComparison.OrdinalIgnoreCase))
                {
                    reviewsQuery = reviewOrderDir == "asc" 
                        ? reviewsQuery.OrderBy(r => r.CreatedAt) 
                        : reviewsQuery.OrderByDescending(r => r.CreatedAt);
                }
                else if (reviewOrderBy.Equals("Rating", StringComparison.OrdinalIgnoreCase))
                {
                    reviewsQuery = reviewOrderDir == "asc" 
                        ? reviewsQuery.OrderBy(r => r.Rating) 
                        : reviewsQuery.OrderByDescending(r => r.Rating);
                }
                
                // Apply pagination
                movie.Reviews = reviewsQuery
                    .Skip(skip)
                    .Take(take)
                    .ToList();
            }
            
            return movie;
        }

        public async Task<IEnumerable<Movie>> GetLatestMoviesAsync(int? userId = null, int count = 6)
        {
            return await _context.Movies
                .OrderByDescending(m => m.DateAired)
                .Take(count)
                .ToListAsync();
        }

        public async Task<(IEnumerable<Movie> Movies, int TotalCount)> GetRelatedMoviesAsync(int id, int? userId, int page, int perPage)
        {
            // Find the movie
            var movie = await _context.Movies
                .Include(m => m.Genres)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (movie == null)
            {
                return (new List<Movie>(), 0);
            }

            // Get genre IDs for the movie
            var genreIds = movie.Genres.Select(mg => mg.GenreId).ToList();
            
            if (!genreIds.Any())
            {
                return (new List<Movie>(), 0);
            }

            // Find movies with the same genres, excluding the current movie
            var relatedMovieIds = await _context.MovieGenres
                .Where(mg => genreIds.Contains(mg.GenreId) && mg.MovieId != id)
                .Select(mg => mg.MovieId)
                .Distinct()
                .ToListAsync();

            if (!relatedMovieIds.Any())
            {
                return (new List<Movie>(), 0);
            }

            // Count total for pagination
            var totalCount = relatedMovieIds.Count;

            // Get paginated movies
            var skip = (page - 1) * perPage;
            var pagedIds = relatedMovieIds.Skip(skip).Take(perPage).ToList();

            var relatedMovies = await _context.Movies
                .Where(m => pagedIds.Contains(m.Id))
                .ToListAsync();

            return (relatedMovies, totalCount);
        }

        public async Task<int> GetMoviesTotalCountAsync()
        {
            return await _context.Movies.CountAsync();
        }

        public async Task<(IEnumerable<Movie> Movies, int TotalCount)> SearchMoviesByTitleAsync(string title, MovieFilterDTO filter)
        {
            var query = _context.Movies
                .Where(m => m.Title.Contains(title));

            // Apply sorting
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

                    query = (IQueryable<Movie>)orderBy.Invoke(
                        null,
                        new object[] { query, GetLambdaExpression<Movie>(filter.SortBy) }
                    );
                }
                else
                {
                    // Default to ordering by title
                    query = filter.AscOrDesc?.ToLower() == "desc" 
                        ? query.OrderByDescending(m => m.Title) 
                        : query.OrderBy(m => m.Title);
                }
            }
            else
            {
                // Default ordering
                query = query.OrderBy(m => m.Title);
            }

            int totalCount = await query.CountAsync();

            var skip = (filter.Page - 1) * filter.PerPage;
            var movies = await query
                .Skip(skip)
                .Take(filter.PerPage)
                .ToListAsync();

            return (movies, totalCount);
        }

        public async Task<bool> IsMovieBookmarkedByUserAsync(int movieId, int userId)
        {
            return await _context.UserMovieFavorites
                .AnyAsync(f => f.MovieId == movieId && f.UserId == userId);
        }

        public async Task<bool> IsMovieReviewedByUserAsync(int movieId, int userId)
        {
            return await _context.MovieReviews
                .AnyAsync(r => r.MovieId == movieId && r.UserId == userId);
        }

        public async Task<(float AverageRating, int TotalReviews)> CalculateMovieRatingAsync(int movieId)
        {
            var reviews = await _context.MovieReviews
                .Where(r => r.MovieId == movieId && r.Rating.HasValue)
                .ToListAsync();

            int totalReviews = reviews.Count;
            
            if (totalReviews == 0)
            {
                return (0, 0);
            }

            float totalRating = reviews.Sum(r => r.Rating ?? 0);
            float averageRating = totalRating / totalReviews;

            return (averageRating, totalReviews);
        }

        public async Task<Dictionary<int, (float AverageRating, int TotalReviews)>> GetMovieRatingsAsync(IEnumerable<int> movieIds)
        {
            var result = new Dictionary<int, (float AverageRating, int TotalReviews)>();

            // Group reviews by movieId and calculate average rating and count
            var ratings = await _context.MovieReviews
                .Where(r => movieIds.Contains(r.MovieId) && r.Rating.HasValue)
                .GroupBy(r => r.MovieId)
                .Select(g => new 
                {
                    MovieId = g.Key,
                    AverageRating = g.Average(r => r.Rating ?? 0),
                    TotalReviews = g.Count()
                })
                .ToListAsync();

            foreach (var rating in ratings)
            {
                result[rating.MovieId] = ((float)rating.AverageRating, rating.TotalReviews);
            }

            // Add entries with zero ratings for any movie IDs not in the result
            foreach (var movieId in movieIds)
            {
                if (!result.ContainsKey(movieId))
                {
                    result[movieId] = (0, 0);
                }
            }

            return result;
        }

        // Helper method to create lambda expressions for dynamic sorting
        private static System.Linq.Expressions.Expression<Func<T, object>> GetLambdaExpression<T>(string propertyName)
        {
            var parameter = System.Linq.Expressions.Expression.Parameter(typeof(T));
            var property = System.Linq.Expressions.Expression.Property(parameter, propertyName);
            var propAsObject = System.Linq.Expressions.Expression.Convert(property, typeof(object));

            return System.Linq.Expressions.Expression.Lambda<Func<T, object>>(propAsObject, parameter);
        }
    }
}