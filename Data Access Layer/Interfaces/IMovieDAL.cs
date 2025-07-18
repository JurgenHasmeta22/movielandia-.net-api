using movielandia_.net_api.DTOs;
using movielandia_.net_api.Models;

namespace movielandia_.net_api.DAL.Interfaces
{
    public interface IMovieDAL : IGenericDAL<Movie>
    {
        Task<(IEnumerable<Movie> Movies, int TotalCount)> GetMoviesWithFiltersAsync(
            MovieFilterDTO filter
        );
        Task<IEnumerable<Movie>> GetMoviesForHomePageAsync();
        Task<IEnumerable<Movie>> GetAllMoviesAsync();
        Task<Movie> GetMovieByIdWithDetailsAsync(int id, MovieQueryParameters parameters);
        Task<Movie> GetMovieByTitleWithDetailsAsync(string title, MovieQueryParameters parameters);
        Task<IEnumerable<Movie>> GetLatestMoviesAsync(int? userId = null, int count = 6);
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

        Task<bool> IsMovieBookmarkedByUserAsync(int movieId, int userId);
        Task<bool> IsMovieReviewedByUserAsync(int movieId, int userId);

        Task<(float AverageRating, int TotalReviews)> CalculateMovieRatingAsync(int movieId);
        Task<Dictionary<int, (float AverageRating, int TotalReviews)>> GetMovieRatingsAsync(
            IEnumerable<int> movieIds
        );
    }
}
