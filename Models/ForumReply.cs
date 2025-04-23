namespace movielandia_.net_api.Models
{
    public class ForumReply
    {
        public int Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public bool IsEdited { get; set; } = false;
        public int EditCount { get; set; } = 0;
        public DateTime? LastEditAt { get; set; }
        public bool IsModerated { get; set; } = false;
        public int PostId { get; set; }
        public int UserId { get; set; }

        // Navigation properties
        public required virtual ForumPost Post { get; set; }
        public virtual required User User { get; set; }
        public virtual ICollection<UpvoteForumReply> Upvotes { get; set; }
        public virtual ICollection<DownvoteForumReply> Downvotes { get; set; }
        public virtual ICollection<ForumReplyHistory> History { get; set; }

        public ForumReply()
        {
            Upvotes = new HashSet<UpvoteForumReply>();
            Downvotes = new HashSet<DownvoteForumReply>();
            History = new HashSet<ForumReplyHistory>();
        }
    }
}
