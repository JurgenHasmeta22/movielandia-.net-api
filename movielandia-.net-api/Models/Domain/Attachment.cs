using System;

namespace movielandia_.net_api.Models.Domain
{
    public class Attachment
    {
        public int Id { get; set; }
        public string Filename { get; set; }
        public string FileUrl { get; set; }
        public int FileSize { get; set; }
        public string MimeType { get; set; }
        public DateTime UploadedAt { get; set; } = DateTime.UtcNow;
        public bool IsPublic { get; set; } = true;
        public string Description { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }

        // Navigation properties
        public virtual User User { get; set; }
        public virtual ForumPost Post { get; set; }
    }
}