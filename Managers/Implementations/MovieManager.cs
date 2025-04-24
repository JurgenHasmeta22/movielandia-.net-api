using AutoMapper;
using Microsoft.Extensions.Caching.Memory;
using movielandia_.net_api.BLLs.Interfaces;
using movielandia_.net_api.DTOs;
using movielandia_.net_api.DTOs.Requests;
using movielandia_.net_api.DTOs.Responses;
using movielandia_.net_api.Managers.Interfaces;
using movielandia_.net_api.Models;

namespace movielandia_.net_api.Managers.Implementations
{
    public class MovieManager : IMovieManager
    {
        #region Fields and Constructor
        private readonly IMovieBLL _movieBLL;
        private readonly IMapper _mapper;
        private readonly IMemoryCache _cache;
        private static readonly TimeSpan CacheDuration = TimeSpan.FromMinutes(30);

        public MovieManager(IMovieBLL movieBLL, IMapper mapper, IMemoryCache cache)
        {
            _movieBLL = movieBLL;
            _mapper = mapper;
            _cache = cache;
        }
        #endregion

        #region Query Methods
        public async Task<MovieListResponse> GetMoviesWithFiltersAsync(MovieFilterDTO filter)
        {
            string cacheKey = $"movies_filtered_{filter.GetHashCode()}";

            if (
                _cache.TryGetValue(cacheKey, out MovieListResponse? cachedResult)
                && cachedResult != null
            )
            {
                return cachedResult;
            }

            var (movies, totalCount) = await _movieBLL.GetMoviesWithFiltersAsync(filter);
            var movieDTOs = _mapper.Map<IEnumerable<MovieDTO>>(movies);

            var response = new MovieListResponse
            {
                Movies = movieDTOs,
                Pagination = new PaginationMetadata
                {
                    CurrentPage = filter.Page,
                    PageSize = filter.PerPage,
                    TotalCount = totalCount,
                    TotalPages = (int)Math.Ceiling(totalCount / (double)filter.PerPage),
                },
            };

            _cache.Set(cacheKey, response, CacheDuration);
            return response;
        }

        public async Task<IEnumerable<MovieDTO>> GetMoviesForHomePageAsync()
        {
            string cacheKey = "movies_homepage";

            if (
                _cache.TryGetValue(cacheKey, out IEnumerable<MovieDTO>? cachedMovies)
                && cachedMovies != null
            )
            {
                return cachedMovies;
            }

            var movies = await _movieBLL.GetMoviesForHomePageAsync();
            var movieDTOs = _mapper.Map<IEnumerable<MovieDTO>>(movies);

            _cache.Set(cacheKey, movieDTOs, CacheDuration);
            return movieDTOs;
        }

        public async Task<MovieDetailResponse> GetMovieByIdAsync(
            int id,
            MovieQueryParameters parameters
        )
        {
            string cacheKey = $"movie_detail_{id}_{parameters.GetHashCode()}";

            if (
                _cache.TryGetValue(cacheKey, out MovieDetailResponse? cachedMovie)
                && cachedMovie != null
            )
            {
                return cachedMovie;
            }

            var movie = await _movieBLL.GetMovieByIdAsync(id, parameters);
            if (movie == null)
                return new MovieDetailResponse(); // Return empty response instead of null

            var movieDTO = _mapper.Map<MovieDetailDTO>(movie);
            var relatedContent = await GetRelatedContentAsync(id, parameters.UserId);

            var response = new MovieDetailResponse
            {
                Movie = movieDTO,
                RelatedContent = relatedContent,
            };

            _cache.Set(cacheKey, response, CacheDuration);
            return response;
        }

        public async Task<MovieDetailResponse> GetMovieByTitleAsync(
            string title,
            MovieQueryParameters parameters
        )
        {
            string cacheKey = $"movie_title_{title}_{parameters.GetHashCode()}";

            if (
                _cache.TryGetValue(cacheKey, out MovieDetailResponse? cachedMovie)
                && cachedMovie != null
            )
            {
                return cachedMovie;
            }

            var movie = await _movieBLL.GetMovieByTitleAsync(title, parameters);
            if (movie == null)
                return new MovieDetailResponse(); // Return empty response instead of null

            var movieDTO = _mapper.Map<MovieDetailDTO>(movie);
            var response = new MovieDetailResponse
            {
                Movie = movieDTO,
                RelatedContent = await GetRelatedContentAsync(movie.Id, parameters.UserId),
            };

            _cache.Set(cacheKey, response, CacheDuration);
            return response;
        }

        public async Task<IEnumerable<MovieDTO>> GetLatestMoviesAsync(int? userId = null)
        {
            string cacheKey = $"movies_latest_{userId}";

            if (
                userId == null
                && _cache.TryGetValue(cacheKey, out IEnumerable<MovieDTO>? cachedMovies)
                && cachedMovies != null
            )
            {
                return cachedMovies;
            }

            var movies = await _movieBLL.GetLatestMoviesAsync(userId);
            var movieDTOs = _mapper.Map<IEnumerable<MovieDTO>>(movies);

            if (userId == null)
            {
                _cache.Set(cacheKey, movieDTOs, CacheDuration);
            }

            return movieDTOs;
        }

        public async Task<(IEnumerable<MovieDTO> Movies, int TotalCount)> GetRelatedMoviesAsync(
            int id,
            int? userId,
            int page,
            int perPage
        )
        {
            string cacheKey = $"movies_related_{id}_{userId}_{page}_{perPage}";

            if (
                userId == null
                && _cache.TryGetValue(
                    cacheKey,
                    out (IEnumerable<MovieDTO> Movies, int TotalCount) cachedResult
                )
            )
            {
                return cachedResult;
            }

            var (movies, totalCount) = await _movieBLL.GetRelatedMoviesAsync(
                id,
                userId,
                page,
                perPage
            );

            var movieDTOs = _mapper.Map<IEnumerable<MovieDTO>>(movies);
            var result = (movieDTOs, totalCount);

            if (userId == null)
            {
                _cache.Set(cacheKey, result, CacheDuration);
            }

            return result;
        }

        public async Task<int> GetMoviesTotalCountAsync()
        {
            string cacheKey = "movies_total_count";

            if (_cache.TryGetValue(cacheKey, out int cachedCount))
            {
                return cachedCount;
            }

            var count = await _movieBLL.GetMoviesTotalCountAsync();
            _cache.Set(cacheKey, count, CacheDuration);

            return count;
        }

        public async Task<MovieListResponse> SearchMoviesAsync(SearchMovieRequestDTO request)
        {
            var (movieList, totalCount) = await _movieBLL.SearchMoviesAsync(
                request.SearchTerm,
                request.Page,
                request.PerPage,
                request.SortBy,
                request.SortDirection,
                request.MinRating,
                request.MaxRating,
                request.FromDate,
                request.ToDate,
                request.GenreIds ?? Enumerable.Empty<int>()
            );

            var movieDTOs = _mapper.Map<IEnumerable<MovieDTO>>(movieList);

            return new MovieListResponse
            {
                Movies = movieDTOs,
                Pagination = new PaginationMetadata
                {
                    CurrentPage = request.Page,
                    PageSize = request.PerPage,
                    TotalCount = totalCount,
                    TotalPages = (int)Math.Ceiling(totalCount / (double)request.PerPage),
                },
            };
        }

        private async Task<RelatedContentMetadata> GetRelatedContentAsync(int movieId, int? userId)
        {
            var similarMovies = await _movieBLL.GetSimilarMoviesAsync(movieId, 6);
            var directorMovies = await _movieBLL.GetMoviesByDirectorAsync(movieId, 6);
            var stats = await _movieBLL.GetMovieStatsAsync(movieId);

            return new RelatedContentMetadata
            {
                TotalReviews = stats.TotalReviews,
                AverageRating = stats.AverageRating,
                ReviewsCount = stats.ReviewsCount,
                BookmarksCount = stats.BookmarksCount,
                SimilarMovies = _mapper.Map<IEnumerable<MovieDTO>>(similarMovies),
                MoreFromDirector = _mapper.Map<IEnumerable<MovieDTO>>(directorMovies),
            };
        }
        #endregion

        #region Command Methods
        public async Task<MovieDTO> CreateMovieAsync(CreateMovieRequestDTO request)
        {
            var movie = _mapper.Map<Movie>(request);
            var createdMovie = await _movieBLL.CreateMovieAsync(movie);
            InvalidateMovieCache();
            return _mapper.Map<MovieDTO>(createdMovie);
        }

        public async Task<MovieDTO> UpdateMovieAsync(int id, UpdateMovieRequestDTO request)
        {
            var movie = _mapper.Map<Movie>(request);
            var updatedMovie = await _movieBLL.UpdateMovieAsync(id, movie);
            InvalidateMovieCache();
            return _mapper.Map<MovieDTO>(updatedMovie);
        }

        public async Task<bool> DeleteMovieAsync(int id)
        {
            var result = await _movieBLL.DeleteMovieAsync(id);

            if (result)
            {
                InvalidateMovieCache();
            }

            return result;
        }
        #endregion

        #region Helper Methods
        private void InvalidateMovieCache()
        {
            _cache.Remove("movies_homepage");
            _cache.Remove("movies_total_count");
        }
        #endregion
    }
}
