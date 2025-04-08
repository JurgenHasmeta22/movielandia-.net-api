namespace movielandia_.net_api.Models.Domain
{
    public class UpvoteForumReply
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ReplyId { get; set; }
        
        // Navigation properties
        public virtual User User { get; set; }
        public virtual ForumReply Reply { get; set; }
    }
}