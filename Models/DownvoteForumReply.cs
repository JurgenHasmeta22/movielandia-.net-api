namespace movielandia_.net_api.Models
{
    public class DownvoteForumReply
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ReplyId { get; set; }

        // Navigation properties
        public required virtual User User { get; set; }
        public virtual required ForumReply Reply { get; set; }
    }
}
