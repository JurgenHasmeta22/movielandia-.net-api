namespace movielandia_.net_api.Models.Domain
{
    public class DownvoteSerieReview
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SerieId { get; set; }
        public int SerieReviewId { get; set; }
        
        // Navigation properties
        public virtual User User { get; set; }
        public virtual Serie Serie { get; set; }
        public virtual SerieReview SerieReview { get; set; }
    }
}