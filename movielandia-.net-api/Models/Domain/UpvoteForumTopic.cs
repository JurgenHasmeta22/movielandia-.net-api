namespace movielandia_.net_api.Models.Domain
{
    public class UpvoteForumTopic
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TopicId { get; set; }
        
        // Navigation properties
        public virtual User User { get; set; }
        public virtual ForumTopic Topic { get; set; }
    }
}