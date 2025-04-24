using movielandia_.net_api.DTOs;
using movielandia_.net_api.DTOs.Requests;
using movielandia_.net_api.DTOs.Responses;

namespace movielandia_.net_api.Managers.Interfaces
{
    public interface IMovieManager
    {
        Task<MovieListResponse> GetMoviesWithFiltersAsync(MovieFilterDTO filter);
        Task<IEnumerable<MovieDTO>> GetMoviesForHomePageAsync();
        Task<MovieDetailResponse> GetMovieByIdAsync(int id, MovieQueryParameters parameters);
        Task<MovieDetailResponse> GetMovieByTitleAsync(
            string title,
            MovieQueryParameters parameters
        );
        Task<MovieDTO> CreateMovieAsync(CreateMovieRequestDTO request);
        Task<MovieDTO> UpdateMovieAsync(int id, UpdateMovieRequestDTO request);
        Task<bool> DeleteMovieAsync(int id);
        Task<IEnumerable<MovieDTO>> GetLatestMoviesAsync(int? userId = null);
        Task<(IEnumerable<MovieDTO> Movies, int TotalCount)> GetRelatedMoviesAsync(
            int movieId,
            int? userId,
            int page,
            int perPage
        );
        Task<MovieListResponse> SearchMoviesAsync(SearchMovieRequestDTO request);
        Task<int> GetMoviesTotalCountAsync();
    }
}
