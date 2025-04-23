namespace movielandia_.net_api.Models
{
    public class UserForumModerator
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }

        // Collections
        public virtual required User User { get; set; }
        public virtual required ForumCategory Category { get; set; }
    }
}
