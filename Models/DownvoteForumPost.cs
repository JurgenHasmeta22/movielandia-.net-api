namespace movielandia_.net_api.Models
{
    public class DownvoteForumPost
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }

        // Collections
        public required virtual User User { get; set; }
        public virtual required ForumPost Post { get; set; }
    }
}
