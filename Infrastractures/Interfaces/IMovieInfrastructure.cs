using System.Collections.Generic;
using System.Threading.Tasks;
using movielandia_.net_api.DTOs;
using movielandia_.net_api.Models.Domain;

namespace movielandia_.net_api.Infrastructures.Interfaces
{
    public interface IMovieInfrastructure
    {
        Task<(IEnumerable<MovieDTO> Movies, int TotalCount)> GetMoviesWithFiltersAsync(
            MovieFilterDTO filter
        );
        Task<IEnumerable<MovieDTO>> GetMoviesForHomePageAsync();
        Task<IEnumerable<Movie>> GetAllMoviesAsync();
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
        Task<MovieDTO> CreateMovieAsync(MovieDTO movieDTO);
        Task<MovieDTO> UpdateMovieAsync(int id, MovieDTO movieDTO);
        Task<bool> DeleteMovieAsync(int id);
        Task<(IEnumerable<MovieDTO> Movies, int TotalCount)> SearchMoviesByTitleAsync(
            string title,
            MovieFilterDTO filter
        );
    }
}
