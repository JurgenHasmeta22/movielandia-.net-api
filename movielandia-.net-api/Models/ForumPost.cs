using System;
using System.Collections.Generic;

namespace movielandia_.net_api.Models.Domain
{
    public class ForumPost
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public bool IsEdited { get; set; } = false;
        public int EditCount { get; set; } = 0;
        public DateTime? LastEditAt { get; set; }
        public bool IsModerated { get; set; } = false;
        public string Slug { get; set; }
        public PostType Type { get; set; } = PostType.Normal;
        public bool IsAnswer { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
        public DateTime? AnsweredAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int TopicId { get; set; }
        public int UserId { get; set; }
        public int? AnsweredById { get; set; }
        public int? DeletedById { get; set; }

        // Navigation properties
        public virtual ForumTopic Topic { get; set; }
        public virtual User User { get; set; }
        public virtual User AnsweredBy { get; set; }
        public virtual User DeletedBy { get; set; }
        public virtual ICollection<Attachment> Attachments { get; set; }
        public virtual ICollection<ForumReply> Replies { get; set; }
        public virtual ICollection<UpvoteForumPost> Upvotes { get; set; }
        public virtual ICollection<DownvoteForumPost> Downvotes { get; set; }
        public virtual ICollection<ForumPostHistory> History { get; set; }
        public virtual ForumCategory LastPostCategory { get; set; }

        public ForumPost()
        {
            Attachments = new HashSet<Attachment>();
            Replies = new HashSet<ForumReply>();
            Upvotes = new HashSet<UpvoteForumPost>();
            Downvotes = new HashSet<DownvoteForumPost>();
            History = new HashSet<ForumPostHistory>();
        }
    }

    public enum PostType
    {
        Normal,
        Announcement,
        Sticky,
        Question,
        Answered
    }
}