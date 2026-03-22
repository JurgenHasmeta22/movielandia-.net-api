using System.ComponentModel.DataAnnotations;
using movielandia_.net_api.Application.Features.Movies.DTOs.Requests;

namespace movielandia_.net_api.Application.Features.Movies.DTOs.Requests;

public sealed class UpdateMovieRequest
{
    [StringLength(200)]
    public string? Title { get; init; }

    [Url]
    public string? PhotoSrc { get; init; }

    [Url]
    public string? PhotoSrcProd { get; init; }

    [Url]
    public string? TrailerSrc { get; init; }

    [Range(1, int.MaxValue)]
    public int? Duration { get; init; }

    [Range(0, 10)]
    public float? RatingImdb { get; init; }

    public DateTime? DateAired { get; init; }

    [StringLength(2000)]
    public string? Description { get; init; }

    public List<int>? GenreIds { get; init; }
    public List<CastMemberRequest>? Cast { get; init; }
    public List<CrewMemberRequest>? Crew { get; init; }
}
