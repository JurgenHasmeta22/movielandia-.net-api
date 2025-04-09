using System;

namespace movielandia_.net_api.Models.Domain
{
    public class UserForumTopicWatch
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public int UserId { get; set; }
        public int TopicId { get; set; }

        // Navigation properties
        public virtual required User User { get; set; }
        public virtual required ForumTopic Topic { get; set; }
    }
}
