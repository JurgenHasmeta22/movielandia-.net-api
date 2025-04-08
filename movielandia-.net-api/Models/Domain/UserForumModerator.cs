using System;

namespace movielandia_.net_api.Models.Domain
{
    public class UserForumModerator
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public int UserId { get; set; }
        public int CategoryId { get; set; }

        // Navigation properties
        public virtual User User { get; set; }
        public virtual ForumCategory Category { get; set; }
    }
}