namespace movielandia_.net_api.Models
{
    public class UpvoteMovieReview
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MovieId { get; set; }
        public int MovieReviewId { get; set; }

        // Collections
        public virtual User? User { get; set; }
        public virtual Movie? Movie { get; set; }
        public virtual MovieReview? MovieReview { get; set; }
    }
}
