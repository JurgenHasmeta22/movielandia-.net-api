using movielandia_.net_api.Application.Common.DTOs;
using movielandia_.net_api.Application.Features.Movies.DTOs;
using movielandia_.net_api.Application.Features.Movies.DTOs.Requests;
using movielandia_.net_api.Application.Features.Movies.DTOs.Responses;

namespace movielandia_.net_api.Application.Features.Movies.Interfaces;

/// <summary>
/// Orchestrates movie business logic, caching, and DTO projection.
/// </summary>
public interface IMovieService
{
    Task<PagedResult<MovieDto>> GetPagedAsync(MovieFilterParams filter);
    Task<IEnumerable<MovieDto>> GetForHomePageAsync();
    Task<IEnumerable<MovieDto>> GetLatestAsync(int? userId = null);
    Task<MovieDetailResponse> GetByIdAsync(int id, MovieQueryParams queryParams);
    Task<MovieDetailResponse> GetByTitleAsync(string title, MovieQueryParams queryParams);
    Task<PagedResult<MovieDto>> SearchAsync(MovieSearchParams search);
    Task<(IEnumerable<MovieDto> Items, int TotalCount)> GetRelatedAsync(int movieId, int? userId, int page, int pageSize);
    Task<int> CountAsync();
    Task<MovieDto> CreateAsync(CreateMovieRequest request);
    Task<MovieDto> UpdateAsync(int id, UpdateMovieRequest request);
    Task DeleteAsync(int id);
}
