namespace movielandia_.net_api.Models.Domain
{
    public class DownvoteForumPost
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        
        // Navigation properties
        public required virtual User User { get; set; }
        public required virtual ForumPost Post { get; set; }
    }
}