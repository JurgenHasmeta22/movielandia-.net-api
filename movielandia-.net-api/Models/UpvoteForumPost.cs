namespace movielandia_.net_api.Models.Domain
{
    public class UpvoteForumPost
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }

        // Navigation properties
        public virtual required User User { get; set; }
        public virtual required ForumPost Post { get; set; }
    }
}
