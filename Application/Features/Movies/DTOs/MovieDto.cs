namespace movielandia_.net_api.Application.Features.Movies.DTOs;

public class MovieDto
{
    public int Id { get; init; }
    public string Title { get; init; } = string.Empty;
    public string PhotoSrc { get; init; } = string.Empty;
    public string PhotoSrcProd { get; init; } = string.Empty;
    public string TrailerSrc { get; init; } = string.Empty;
    public int Duration { get; init; }
    public float RatingImdb { get; init; }
    public DateTime? DateAired { get; init; }
    public string Description { get; init; } = string.Empty;
    public float? AverageRating { get; init; }
    public bool IsBookmarked { get; init; }
    public bool IsReviewed { get; init; }
}
