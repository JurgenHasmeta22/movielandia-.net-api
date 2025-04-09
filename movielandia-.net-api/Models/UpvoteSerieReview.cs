namespace movielandia_.net_api.Models.Domain
{
    public class UpvoteSerieReview
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SerieId { get; set; }
        public int SerieReviewId { get; set; }
        
        // Navigation properties
        public virtual required User User { get; set; }
        public virtual required Serie Serie { get; set; }
        public virtual required SerieReview SerieReview { get; set; }
    }
}