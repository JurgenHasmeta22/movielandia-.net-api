using System;

namespace movielandia_.net_api.Models.Domain
{
    public class ForumReplyHistory
    {
        public int Id { get; set; }
        public string OldContent { get; set; }
        public string NewContent { get; set; }
        public DateTime EditedAt { get; set; } = DateTime.UtcNow;
        public string Reason { get; set; }
        public int ReplyId { get; set; }
        public int EditedById { get; set; }
        
        // Navigation properties
        public required virtual ForumReply Reply { get; set; }
        public required virtual User EditedBy { get; set; }
    }
}