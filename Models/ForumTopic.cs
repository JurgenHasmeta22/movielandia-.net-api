using movielandia_.net_api.Enums;

namespace movielandia_.net_api.Models
{
    public class ForumTopic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public int ViewCount { get; set; } = 0;
        public bool IsPinned { get; set; } = false;
        public string Slug { get; set; }
        public DateTime LastPostAt { get; set; } = DateTime.UtcNow;
        public bool IsModerated { get; set; } = false;
        public DateTime? ClosedAt { get; set; }
        public TopicStatus Status { get; set; } = TopicStatus.Open;
        public int? ClosedById { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }

        // Navigation properties
        public virtual User? ClosedBy { get; set; }
        public virtual required ForumCategory Category { get; set; }
        public virtual required User User { get; set; }
        public virtual ICollection<ForumPost> Posts { get; set; }
        public virtual ICollection<UserForumTopicFavorite> UsersWhoBookmarkedIt { get; set; }
        public virtual ICollection<UpvoteForumTopic> Upvotes { get; set; }
        public virtual ICollection<DownvoteForumTopic> Downvotes { get; set; }
        public virtual ICollection<UserForumTopicWatch> Watchers { get; set; }
        public virtual ICollection<ForumTag> Tags { get; set; }

        public ForumTopic()
        {
            Title = string.Empty;
            Description = string.Empty;
            Slug = string.Empty;
            Posts = new HashSet<ForumPost>();
            UsersWhoBookmarkedIt = new HashSet<UserForumTopicFavorite>();
            Upvotes = new HashSet<UpvoteForumTopic>();
            Downvotes = new HashSet<DownvoteForumTopic>();
            Watchers = new HashSet<UserForumTopicWatch>();
            Tags = new HashSet<ForumTag>();
        }
    }
}
