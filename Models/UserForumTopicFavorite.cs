namespace movielandia_.net_api.Models
{
    public class UserForumTopicFavorite
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TopicId { get; set; }

        // Collections
        public virtual required User User { get; set; }
        public virtual required ForumTopic Topic { get; set; }
    }
}
