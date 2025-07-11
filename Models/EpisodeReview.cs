namespace movielandia_.net_api.Models
{
    public class EpisodeReview
    {
        public int Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public float? Rating { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int UserId { get; set; }
        public int EpisodeId { get; set; }

        // Collections
        public virtual User User { get; set; } = null!;
        public virtual Episode Episode { get; set; } = null!;
        public virtual ICollection<UpvoteEpisodeReview> Upvotes { get; set; }
        public virtual ICollection<DownvoteEpisodeReview> Downvotes { get; set; }

        public EpisodeReview()
        {
            Upvotes = new HashSet<UpvoteEpisodeReview>();
            Downvotes = new HashSet<DownvoteEpisodeReview>();
        }
    }
}
