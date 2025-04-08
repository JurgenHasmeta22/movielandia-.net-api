namespace movielandia_.net_api.Models.Domain
{
    public class DownvoteMovieReview
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MovieId { get; set; }
        public int MovieReviewId { get; set; }
        
        // Navigation properties
        public required virtual User User { get; set; }
        public required virtual Movie Movie { get; set; }
        public required virtual MovieReview MovieReview { get; set; }
    }
}