using System.ComponentModel.DataAnnotations;

namespace movielandia_.net_api.Application.Features.Movies.DTOs.Requests;

public sealed class CreateMovieRequest
{
    [Required, StringLength(200)]
    public string Title { get; init; } = string.Empty;

    [Required, Url]
    public string PhotoSrc { get; init; } = string.Empty;

    [Required, Url]
    public string PhotoSrcProd { get; init; } = string.Empty;

    [Required, Url]
    public string TrailerSrc { get; init; } = string.Empty;

    [Required, Range(1, int.MaxValue)]
    public int Duration { get; init; }

    [Required, Range(0, 10)]
    public float RatingImdb { get; init; }

    public DateTime? DateAired { get; init; }

    [Required, StringLength(2000)]
    public string Description { get; init; } = string.Empty;

    [Required]
    public List<int> GenreIds { get; init; } = [];

    [Required]
    public List<CastMemberRequest> Cast { get; init; } = [];

    [Required]
    public List<CrewMemberRequest> Crew { get; init; } = [];
}

public sealed class CastMemberRequest
{
    [Required, Range(1, int.MaxValue)]
    public int ActorId { get; init; }

    [Required, StringLength(100)]
    public string Role { get; init; } = string.Empty;
}

public sealed class CrewMemberRequest
{
    [Required, Range(1, int.MaxValue)]
    public int CrewId { get; init; }

    [Required, StringLength(100)]
    public string Role { get; init; } = string.Empty;
}
