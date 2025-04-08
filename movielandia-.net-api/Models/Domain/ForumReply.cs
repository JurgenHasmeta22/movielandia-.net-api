using System;
using System.Collections.Generic;

namespace movielandia_.net_api.Models.Domain
{
    public class ForumReply
    {
        public int Id { get; set; }
        public string Content { get; set; }
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
        public required virtual User User { get; set; }
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