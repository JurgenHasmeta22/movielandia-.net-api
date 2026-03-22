using System.ComponentModel.DataAnnotations;
using movielandia_.net_api.Domain.Enums;

namespace movielandia_.net_api.Application.Features.Movies.DTOs;

/// <summary>
/// Query parameters for paginated + filtered movie listings.
/// </summary>
public sealed class MovieFilterParams
{
    public string SortBy { get; init; } = "title";
    public string AscOrDesc { get; init; } = "asc";

    [Range(1, 100)]
    public int PageSize { get; init; } = 12;

    [Range(1, int.MaxValue)]
    public int Page { get; init; } = 1;

    public string? Title { get; init; }
    public object? FilterValue { get; init; }
    public string? FilterField { get; init; }
    public FilterOperator? FilterOperator { get; init; }
    public int? UserId { get; init; }
}

/// <summary>
/// Query parameters used when fetching a movie detail page (controls sub-collection pagination).
/// </summary>
public sealed class MovieQueryParams
{
    public int ReviewsPage { get; init; } = 1;
    public string ReviewsSortBy { get; init; } = "createdAt";
    public string ReviewsAscOrDesc { get; init; } = "desc";
    public int CastPage { get; init; } = 1;
    public int CrewPage { get; init; } = 1;
    public int? UserId { get; init; }
}

/// <summary>
/// Full-text search parameters for the movie search endpoint.
/// </summary>
public sealed class MovieSearchParams
{
    [Required, MinLength(2)]
    public string SearchTerm { get; init; } = string.Empty;

    [Range(1, int.MaxValue)]
    public int Page { get; init; } = 1;

    [Range(1, 100)]
    public int PageSize { get; init; } = 12;

    public string SortBy { get; init; } = "title";
    public string SortDirection { get; init; } = "asc";
    public float? MinRating { get; init; }
    public float? MaxRating { get; init; }
    public DateTime? FromDate { get; init; }
    public DateTime? ToDate { get; init; }
    public IEnumerable<int>? GenreIds { get; init; }
}
