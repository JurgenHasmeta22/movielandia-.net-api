namespace movielandia_.net_api.Models
{
    public class UpvoteForumReply
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ReplyId { get; set; }

        // Navigation properties
        public virtual required User User { get; set; }
        public virtual required ForumReply Reply { get; set; }
    }
}
