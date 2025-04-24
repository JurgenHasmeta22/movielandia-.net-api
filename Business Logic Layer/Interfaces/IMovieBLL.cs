using movielandia_.net_api.DTOs;
using movielandia_.net_api.Models;

namespace movielandia_.net_api.BLLs.Interfaces
{
    public interface IMovieBLL
    {
        Task<IEnumerable<Movie>> GetAllMoviesAsync();
        Task<(IEnumerable<Movie> Movies, int TotalCount)> GetMoviesWithFiltersAsync(
            MovieFilterDTO filter
        );
        Task<IEnumerable<Movie>> GetMoviesForHomePageAsync();
        Task<Movie> GetMovieByIdAsync(int id, MovieQueryParameters parameters);
        Task<Movie> GetMovieByTitleAsync(string title, MovieQueryParameters parameters);
        Task<IEnumerable<Movie>> GetLatestMoviesAsync(int? userId = null);
        Task<(IEnumerable<Movie> Movies, int TotalCount)> GetRelatedMoviesAsync(
            int id,
            int? userId,
            int page,
            int perPage
        );
        Task<int> GetMoviesTotalCountAsync();
        Task<(IEnumerable<Movie> Movies, int TotalCount)> SearchMoviesByTitleAsync(
            string title,
            MovieFilterDTO filter
        );
        Task<Movie> CreateMovieAsync(Movie movie);
        Task<Movie> UpdateMovieAsync(int id, Movie movie);
        Task<bool> DeleteMovieAsync(int id);

        // New methods
        Task<(IEnumerable<Movie> Movies, int TotalCount)> SearchMoviesAsync(
            string searchTerm,
            int page,
            int perPage,
            string sortBy,
            string sortDirection,
            float? minRating,
            float? maxRating,
            DateTime? fromDate,
            DateTime? toDate,
            IEnumerable<int> genreIds
        );
        Task<IEnumerable<Movie>> GetSimilarMoviesAsync(int movieId, int count);
        Task<IEnumerable<Movie>> GetMoviesByDirectorAsync(int movieId, int count);
        Task<(
            float AverageRating,
            int TotalReviews,
            int ReviewsCount,
            int BookmarksCount
        )> GetMovieStatsAsync(int movieId);
    }
}
