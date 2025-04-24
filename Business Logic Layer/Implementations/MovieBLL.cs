using movielandia_.net_api.BLLs.Interfaces;
using movielandia_.net_api.DAL.Interfaces;
using movielandia_.net_api.DTOs;
using movielandia_.net_api.Models;

namespace movielandia_.net_api.BLLs.Implementations
{
    public class MovieBLL : IMovieBLL
    {
        #region Fields and Constructor
        private readonly IMovieDAL _movieDAL;

        public MovieBLL(IMovieDAL movieDAL)
        {
            _movieDAL = movieDAL;
        }
        #endregion

        #region Basic Queries
        public async Task<IEnumerable<Movie>> GetAllMoviesAsync()
        {
            return await _movieDAL.GetAllMoviesAsync();
        }

        public async Task<int> GetMoviesTotalCountAsync()
        {
            return await _movieDAL.GetMoviesTotalCountAsync();
        }
        #endregion

        #region Filtered Queries
        public async Task<(IEnumerable<Movie> Movies, int TotalCount)> GetMoviesWithFiltersAsync(
            MovieFilterDTO filter
        )
        {
            return await _movieDAL.GetMoviesWithFiltersAsync(filter);
        }

        public async Task<IEnumerable<Movie>> GetMoviesForHomePageAsync()
        {
            return await _movieDAL.GetMoviesForHomePageAsync();
        }

        public async Task<IEnumerable<Movie>> GetLatestMoviesAsync(int? userId = null)
        {
            return await _movieDAL.GetLatestMoviesAsync(userId);
        }

        public async Task<(IEnumerable<Movie> Movies, int TotalCount)> GetRelatedMoviesAsync(
            int id,
            int? userId,
            int page,
            int perPage
        )
        {
            return await _movieDAL.GetRelatedMoviesAsync(id, userId, page, perPage);
        }
        #endregion

        #region Detailed Queries
        public async Task<Movie> GetMovieByIdAsync(int id, MovieQueryParameters parameters)
        {
            var movie = await _movieDAL.GetMovieByIdWithDetailsAsync(id, parameters);
            if (movie == null)
            {
                throw new KeyNotFoundException("Movie not found.");
            }
            return movie;
        }

        public async Task<Movie> GetMovieByTitleAsync(string title, MovieQueryParameters parameters)
        {
            var movie = await _movieDAL.GetMovieByTitleWithDetailsAsync(title, parameters);
            if (movie == null)
            {
                throw new KeyNotFoundException("Movie not found.");
            }
            return movie;
        }
        #endregion

        #region Search Operations
        public async Task<(IEnumerable<Movie> Movies, int TotalCount)> SearchMoviesByTitleAsync(
            string title,
            MovieFilterDTO filter
        )
        {
            return await _movieDAL.SearchMoviesByTitleAsync(title, filter);
        }
        #endregion

        #region CRUD Operations
        public async Task<Movie> CreateMovieAsync(Movie movie)
        {
            return await _movieDAL.AddAsync(movie);
        }

        public async Task<Movie> UpdateMovieAsync(int id, Movie movie)
        {
            var existingMovie = await _movieDAL.GetByIdAsync(id);

            if (existingMovie == null)
            {
                throw new KeyNotFoundException($"Movie with ID {id} not found.");
            }

            existingMovie.Title = movie.Title;
            existingMovie.PhotoSrc = movie.PhotoSrc;
            existingMovie.PhotoSrcProd = movie.PhotoSrcProd;
            existingMovie.TrailerSrc = movie.TrailerSrc;
            existingMovie.Duration = movie.Duration;
            existingMovie.RatingImdb = movie.RatingImdb;
            existingMovie.DateAired = movie.DateAired;
            existingMovie.Description = movie.Description;

            await _movieDAL.UpdateAsync(existingMovie);
            return existingMovie;
        }

        public async Task<bool> DeleteMovieAsync(int id)
        {
            var movie = await _movieDAL.GetByIdAsync(id);
            if (movie == null)
            {
                return false;
            }

            await _movieDAL.DeleteAsync(movie.Id);
            return true;
        }
        #endregion
    }
}
