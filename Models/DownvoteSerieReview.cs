namespace movielandia_.net_api.Models
{
    public class DownvoteSerieReview
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SerieId { get; set; }
        public int SerieReviewId { get; set; }

        // Collections
        public virtual required User User { get; set; }
        public virtual required Serie Serie { get; set; }
        public virtual required SerieReview SerieReview { get; set; }
    }
}
