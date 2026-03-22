using movielandia_.net_api.Application.Common.DTOs;

namespace movielandia_.net_api.Application.Features.Movies.DTOs.Responses;

public sealed class MovieListResponse
{
    public required IEnumerable<MovieDto> Movies { get; init; }
    public required PagedResult<MovieDto> Pagination { get; init; }
}

public sealed class MovieDetailResponse
{
    public required MovieDetailDto Movie { get; init; }
    public required MovieStats Stats { get; init; }
}

public sealed class MovieStats
{
    public float AverageRating { get; init; }
    public int TotalReviews { get; init; }
    public int BookmarksCount { get; init; }
    public IEnumerable<MovieDto> SimilarMovies { get; init; } = [];
}
