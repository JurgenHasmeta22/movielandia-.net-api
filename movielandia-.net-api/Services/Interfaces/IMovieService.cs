using System.Collections.Generic;
using System.Threading.Tasks;
using movielandia_.net_api.Models.Domain;
using movielandia_.net_api.Models.DTOs;

namespace movielandia_.net_api.Services.Interfaces
{
    public interface IMovieService
    {
        Task<(IEnumerable<MovieDto> Movies, int TotalCount)> GetMoviesWithFiltersAsync(MovieFilterDto filter);
        Task<IEnumerable<MovieDto>> GetMoviesForHomePageAsync();
        Task<IEnumerable<Movie>> GetAllMoviesAsync();
        Task<MovieDetailDto> GetMovieByIdAsync(int id, MovieQueryParameters parameters);
        Task<MovieDetailDto> GetMovieByTitleAsync(string title, MovieQueryParameters parameters);
        Task<IEnumerable<MovieDto>> GetLatestMoviesAsync(int? userId = null);
        Task<(IEnumerable<MovieDto> Movies, int TotalCount)> GetRelatedMoviesAsync(int id, int? userId, int page, int perPage);
        Task<int> GetMoviesTotalCountAsync();
        Task<MovieDto> CreateMovieAsync(MovieDto movieDto);
        Task<MovieDto> UpdateMovieAsync(int id, MovieDto movieDto);
        Task<bool> DeleteMovieAsync(int id);
        Task<(IEnumerable<MovieDto> Movies, int TotalCount)> SearchMoviesByTitleAsync(string title, MovieFilterDto filter);
    }
}