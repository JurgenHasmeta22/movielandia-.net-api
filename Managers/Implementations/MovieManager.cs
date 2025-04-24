using AutoMapper;
using Microsoft.Extensions.Caching.Memory;
using movielandia_.net_api.BLLs.Interfaces;
using movielandia_.net_api.DTOs;
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
        public async Task<(IEnumerable<MovieDTO> Movies, int TotalCount)> GetMoviesWithFiltersAsync(
            MovieFilterDTO filter
        )
        {
            string cacheKey = $"movies_filtered_{filter.GetHashCode()}";

            if (
                _cache.TryGetValue(
                    cacheKey,
                    out (IEnumerable<MovieDTO> Movies, int TotalCount) cachedResult
                )
            )
            {
                return cachedResult;
            }

            var (movies, totalCount) = await _movieBLL.GetMoviesWithFiltersAsync(filter);
            var movieDTOs = _mapper.Map<IEnumerable<MovieDTO>>(movies);
            var result = (movieDTOs, totalCount);

            _cache.Set(cacheKey, result, CacheDuration);
            return result;
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

        public async Task<MovieDetailDTO> GetMovieByIdAsync(int id, MovieQueryParameters parameters)
        {
            string cacheKey = $"movie_detail_{id}_{parameters.GetHashCode()}";

            if (
                _cache.TryGetValue(cacheKey, out MovieDetailDTO? cachedMovie)
                && cachedMovie != null
            )
            {
                return cachedMovie;
            }

            var movie = await _movieBLL.GetMovieByIdAsync(id, parameters);
            var movieDTO = _mapper.Map<MovieDetailDTO>(movie);

            _cache.Set(cacheKey, movieDTO, CacheDuration);
            return movieDTO;
        }

        public async Task<MovieDetailDTO> GetMovieByTitleAsync(
            string title,
            MovieQueryParameters parameters
        )
        {
            string cacheKey = $"movie_title_{title}_{parameters.GetHashCode()}";

            if (
                _cache.TryGetValue(cacheKey, out MovieDetailDTO? cachedMovie)
                && cachedMovie != null
            )
            {
                return cachedMovie;
            }

            var movie = await _movieBLL.GetMovieByTitleAsync(title, parameters);
            var movieDTO = _mapper.Map<MovieDetailDTO>(movie);

            _cache.Set(cacheKey, movieDTO, CacheDuration);
            return movieDTO;
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

        public async Task<(IEnumerable<MovieDTO> Movies, int TotalCount)> SearchMoviesByTitleAsync(
            string title,
            MovieFilterDTO filter
        )
        {
            var (movies, totalCount) = await _movieBLL.SearchMoviesByTitleAsync(title, filter);
            var movieDTOs = _mapper.Map<IEnumerable<MovieDTO>>(movies);
            return (movieDTOs, totalCount);
        }
        #endregion

        #region Command Methods
        public async Task<MovieDTO> CreateMovieAsync(MovieDTO movieDTO)
        {
            var movie = _mapper.Map<Movie>(movieDTO);
            var createdMovie = await _movieBLL.CreateMovieAsync(movie);
            InvalidateMovieCache();
            return _mapper.Map<MovieDTO>(createdMovie);
        }

        public async Task<MovieDTO> UpdateMovieAsync(int id, MovieDTO movieDTO)
        {
            var movie = _mapper.Map<Movie>(movieDTO);
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
