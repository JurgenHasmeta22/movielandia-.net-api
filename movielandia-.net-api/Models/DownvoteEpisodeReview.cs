namespace movielandia_.net_api.Models.Domain
{
    public class DownvoteEpisodeReview
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int EpisodeId { get; set; }
        public int EpisodeReviewId { get; set; }
        
        // Navigation properties
        public required virtual User User { get; set; }
        public required virtual Episode Episode { get; set; }
        public required virtual EpisodeReview EpisodeReview { get; set; }
    }
}