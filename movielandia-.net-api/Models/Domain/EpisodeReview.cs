using System;
using System.Collections.Generic;

namespace movielandia_.net_api.Models.Domain
{
    public class EpisodeReview
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public float? Rating { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public int UserId { get; set; }
        public int EpisodeId { get; set; }
        
        // Navigation properties
        public virtual User User { get; set; }
        public virtual Episode Episode { get; set; }
        public virtual ICollection<UpvoteEpisodeReview> Upvotes { get; set; }
        public virtual ICollection<DownvoteEpisodeReview> Downvotes { get; set; }

        public EpisodeReview()
        {
            Upvotes = new HashSet<UpvoteEpisodeReview>();
            Downvotes = new HashSet<DownvoteEpisodeReview>();
        }
    }
}