using System;

namespace movielandia_.net_api.Models.Domain
{
    public class Attachment
    {
        public int Id { get; set; }
        public required string Filename { get; set; }
        public required string FileUrl { get; set; }
        public int FileSize { get; set; }
        public required string MimeType { get; set; }
        public DateTime UploadedAt { get; set; } = DateTime.UtcNow;
        public bool IsPublic { get; set; } = true;
        public required string Description { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }

        // Navigation properties
        public virtual required User User { get; set; }
        public virtual required ForumPost Post { get; set; }
    }
}
