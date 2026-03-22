namespace movielandia_.net_api.Application.Features.Movies.DTOs;

public sealed class MovieDetailDto : MovieDto
{
    public IEnumerable<MovieGenreDto> Genres { get; init; } = [];
    public IEnumerable<MovieCastDto> Cast { get; init; } = [];
    public IEnumerable<MovieCrewDto> Crew { get; init; } = [];
    public IEnumerable<MovieReviewDto> Reviews { get; init; } = [];
}

public sealed class MovieGenreDto
{
    public int Id { get; init; }
    public int GenreId { get; init; }
    public string Name { get; init; } = string.Empty;
}

public sealed class MovieCastDto
{
    public int Id { get; init; }
    public int ActorId { get; init; }
    public string Fullname { get; init; } = string.Empty;
    public string PhotoSrc { get; init; } = string.Empty;
}

public sealed class MovieCrewDto
{
    public int Id { get; init; }
    public int CrewId { get; init; }
    public string Fullname { get; init; } = string.Empty;
    public string Role { get; init; } = string.Empty;
    public string PhotoSrc { get; init; } = string.Empty;
}

public sealed class MovieReviewDto
{
    public int Id { get; init; }
    public string Content { get; init; } = string.Empty;
    public float? Rating { get; init; }
    public DateTime CreatedAt { get; init; }
    public DateTime? UpdatedAt { get; init; }
    public int UserId { get; init; }
    public string UserName { get; init; } = string.Empty;
    public int UpvotesCount { get; init; }
    public int DownvotesCount { get; init; }
    public bool IsUpvoted { get; init; }
    public bool IsDownvoted { get; init; }
}
