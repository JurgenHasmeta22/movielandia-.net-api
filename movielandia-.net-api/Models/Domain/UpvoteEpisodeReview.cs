namespace movielandia_.net_api.Models.Domain
{
    public class UpvoteEpisodeReview
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int EpisodeId { get; set; }
        public int EpisodeReviewId { get; set; }
        
        // Navigation properties
        public virtual User User { get; set; }
        public virtual Episode Episode { get; set; }
        public virtual EpisodeReview EpisodeReview { get; set; }
    }
}