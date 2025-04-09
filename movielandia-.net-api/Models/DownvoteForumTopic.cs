namespace movielandia_.net_api.Models.Domain
{
    public class DownvoteForumTopic
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TopicId { get; set; }

        // Navigation properties
        public required virtual User User { get; set; }
        public virtual required ForumTopic Topic { get; set; }
    }
}
