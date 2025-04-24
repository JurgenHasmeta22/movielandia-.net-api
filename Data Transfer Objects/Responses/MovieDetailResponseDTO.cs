namespace movielandia_.net_api.DTOs.Responses
{
    public class MovieDetailResponse
    {
        public MovieDetailDTO Movie { get; set; }
        public RelatedContentMetadata RelatedContent { get; set; }
    }

    public class RelatedContentMetadata
    {
        public int TotalReviews { get; set; }
        public float AverageRating { get; set; }
        public int ReviewsCount { get; set; }
        public int BookmarksCount { get; set; }
        public IEnumerable<MovieDTO> SimilarMovies { get; set; }
        public IEnumerable<MovieDTO> MoreFromDirector { get; set; }
    }
}
