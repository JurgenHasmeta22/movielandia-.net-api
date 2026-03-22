using movielandia_.net_api.Application.Common.Interfaces;
using movielandia_.net_api.Application.Features.Movies.DTOs;
using movielandia_.net_api.Domain.Entities;

namespace movielandia_.net_api.Application.Features.Movies.Interfaces;

/// <summary>
/// Movie-specific data access contract extending the generic repository.
/// </summary>
public interface IMovieRepository : IRepository<Movie>
{
    Task<IEnumerable<Movie>> GetForHomePageAsync();
    Task<IEnumerable<Movie>> GetLatestAsync(int count = 6);
    Task<Movie?> GetWithDetailsAsync(int id, MovieQueryParams queryParams);
    Task<Movie?> GetWithDetailsByTitleAsync(string title, MovieQueryParams queryParams);
    Task<(IEnumerable<Movie> Items, int TotalCount)> GetPagedAsync(MovieFilterParams filter);
    Task<(IEnumerable<Movie> Items, int TotalCount)> GetRelatedAsync(int movieId, int page, int pageSize);
    Task<(IEnumerable<Movie> Items, int TotalCount)> SearchAsync(MovieSearchParams search);
    Task<int> CountAsync();
    Task<bool> IsBookmarkedByUserAsync(int movieId, int userId);
    Task<bool> IsReviewedByUserAsync(int movieId, int userId);
    Task<(float AverageRating, int TotalReviews)> GetRatingStatsAsync(int movieId);
    Task<Dictionary<int, (float AverageRating, int TotalReviews)>> GetBulkRatingStatsAsync(IEnumerable<int> movieIds);
}
