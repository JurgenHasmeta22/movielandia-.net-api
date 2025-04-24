namespace movielandia_.net_api.DTOs.Responses
{
    public class MovieDetailResponseDTO
    {
        public required MovieDetailDTO Movie { get; set; }
        public required RelatedContentMetadata RelatedContent { get; set; }
    }

    public class RelatedContentMetadata
    {
        public int TotalReviews { get; set; }
        public float AverageRating { get; set; }
        public int ReviewsCount { get; set; }
        public int BookmarksCount { get; set; }
        public required IEnumerable<MovieDTO> SimilarMovies { get; set; }
        public required IEnumerable<MovieDTO> MoreFromDirector { get; set; }
    }
}
