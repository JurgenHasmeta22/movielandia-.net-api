using movielandia_.net_api.Enums;

namespace movielandia_.net_api.Models
{
    public class ForumPost
    {
        public int Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool IsEdited { get; set; } = false;
        public int EditCount { get; set; } = 0;
        public DateTime? LastEditAt { get; set; }
        public bool IsModerated { get; set; } = false;
        public string Slug { get; set; } = string.Empty;
        public PostType Type { get; set; } = PostType.Normal;
        public bool IsAnswer { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
        public DateTime? AnsweredAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int TopicId { get; set; }
        public int UserId { get; set; }
        public int? AnsweredById { get; set; }
        public int? DeletedById { get; set; }

        // Collections
        public virtual required ForumTopic Topic { get; set; }
        public virtual required User User { get; set; }
        public virtual User? AnsweredBy { get; set; }
        public virtual User? DeletedBy { get; set; }
        public virtual ICollection<Attachment> Attachments { get; set; }
        public virtual ICollection<ForumReply> Replies { get; set; }
        public virtual ICollection<UpvoteForumPost> Upvotes { get; set; }
        public virtual ICollection<DownvoteForumPost> Downvotes { get; set; }
        public virtual ICollection<ForumPostHistory> History { get; set; }
        public virtual ForumCategory? LastPostCategory { get; set; }

        public ForumPost()
        {
            Content = string.Empty;
            Slug = string.Empty;
            Attachments = new HashSet<Attachment>();
            Replies = new HashSet<ForumReply>();
            Upvotes = new HashSet<UpvoteForumPost>();
            Downvotes = new HashSet<DownvoteForumPost>();
            History = new HashSet<ForumPostHistory>();
        }
    }
}
