namespace movielandia_.net_api.Models
{
    public class ForumCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Order { get; set; } = 0;
        public bool IsActive { get; set; } = true;
        public string Slug { get; set; }
        public int TopicCount { get; set; } = 0;
        public int PostCount { get; set; } = 0;
        public DateTime? LastPostAt { get; set; }
        public int? LastPostId { get; set; }

        // Collections
        public virtual ForumPost? LastPost { get; set; }
        public virtual ICollection<ForumTopic> Topics { get; set; }
        public virtual ICollection<UserForumModerator> Moderators { get; set; }

        public ForumCategory()
        {
            Name = string.Empty;
            Description = string.Empty;
            Slug = string.Empty;
            Topics = new HashSet<ForumTopic>();
            Moderators = new HashSet<UserForumModerator>();
        }
    }
}
