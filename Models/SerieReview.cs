using System;
using System.Collections.Generic;

namespace movielandia_.net_api.Models
{
    public class SerieReview
    {
        public int Id { get; set; }
        public required string Content { get; set; }
        public float? Rating { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public int UserId { get; set; }
        public int SerieId { get; set; }

        // Navigation properties
        public virtual required User User { get; set; }
        public virtual required Serie Serie { get; set; }
        public virtual ICollection<UpvoteSerieReview> Upvotes { get; set; }
        public virtual ICollection<DownvoteSerieReview> Downvotes { get; set; }

        public SerieReview()
        {
            Upvotes = new HashSet<UpvoteSerieReview>();
            Downvotes = new HashSet<DownvoteSerieReview>();
        }
    }
}
