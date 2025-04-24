using movielandia_.net_api.DTOs;

namespace movielandia_.net_api.Managers.Interfaces
{
    public interface IMovieManager
    {
        Task<(IEnumerable<MovieDTO> Movies, int TotalCount)> GetMoviesWithFiltersAsync(
            MovieFilterDTO filter
        );
        Task<IEnumerable<MovieDTO>> GetMoviesForHomePageAsync();
        Task<MovieDetailDTO> GetMovieByIdAsync(int id, MovieQueryParameters parameters);
        Task<MovieDetailDTO> GetMovieByTitleAsync(string title, MovieQueryParameters parameters);
        Task<IEnumerable<MovieDTO>> GetLatestMoviesAsync(int? userId = null);
        Task<(IEnumerable<MovieDTO> Movies, int TotalCount)> GetRelatedMoviesAsync(
            int id,
            int? userId,
            int page,
            int perPage
        );
        Task<int> GetMoviesTotalCountAsync();
        Task<(IEnumerable<MovieDTO> Movies, int TotalCount)> SearchMoviesByTitleAsync(
            string title,
            MovieFilterDTO filter
        );
        Task<MovieDTO> CreateMovieAsync(MovieDTO movieDTO);
        Task<MovieDTO> UpdateMovieAsync(int id, MovieDTO movieDTO);
        Task<bool> DeleteMovieAsync(int id);
    }
}
