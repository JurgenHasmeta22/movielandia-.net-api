using System;
using System.Collections.Generic;

namespace movielandia_.net_api.Models.Domain
{
    public class ForumCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; }
        public int Order { get; set; } = 0;
        public bool IsActive { get; set; } = true;
        public string Slug { get; set; }
        public int TopicCount { get; set; } = 0;
        public int PostCount { get; set; } = 0;
        public DateTime? LastPostAt { get; set; }
        public int? LastPostId { get; set; }

        // Navigation properties
        public virtual ForumPost? LastPost { get; set; }
        public virtual ICollection<ForumTopic> Topics { get; set; }
        public virtual ICollection<UserForumModerator> Moderators { get; set; }

        public ForumCategory()
        {
            Topics = new HashSet<ForumTopic>();
            Moderators = new HashSet<UserForumModerator>();
        }
    }
}