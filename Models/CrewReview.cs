namespace movielandia_.net_api.Models
{
    public class CrewReview
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public float? Rating { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int UserId { get; set; }
        public int CrewId { get; set; }

        // Collections
        public required virtual User User { get; set; }
        public virtual required Crew Crew { get; set; }
        public virtual ICollection<UpvoteCrewReview> Upvotes { get; set; }
        public virtual ICollection<DownvoteCrewReview> Downvotes { get; set; }

        public CrewReview()
        {
            Content = "";
            Upvotes = new HashSet<UpvoteCrewReview>();
            Downvotes = new HashSet<DownvoteCrewReview>();
        }
    }
}
