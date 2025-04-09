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
        public virtual required Episode Episode { get; set; }
        public virtual required EpisodeReview EpisodeReview { get; set; }
    }
}
