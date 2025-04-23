namespace movielandia_.net_api.Models
{
    public class SeasonReview
    {
        public int Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public float? Rating { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int UserId { get; set; }
        public int SeasonId { get; set; }

        // Collections
        public virtual User User { get; set; } = null!;
        public virtual Season Season { get; set; } = null!;
        public virtual ICollection<UpvoteSeasonReview> Upvotes { get; set; }
        public virtual ICollection<DownvoteSeasonReview> Downvotes { get; set; }

        public SeasonReview()
        {
            Upvotes = new HashSet<UpvoteSeasonReview>();
            Downvotes = new HashSet<DownvoteSeasonReview>();
        }
    }
}
