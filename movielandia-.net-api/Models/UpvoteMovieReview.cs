namespace movielandia_.net_api.Models.Domain
{
    public class UpvoteMovieReview
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MovieId { get; set; }
        public int MovieReviewId { get; set; }

        // Navigation properties
        public virtual required User User { get; set; }
        public virtual required Movie Movie { get; set; }
        public virtual required MovieReview MovieReview { get; set; }
    }
}
