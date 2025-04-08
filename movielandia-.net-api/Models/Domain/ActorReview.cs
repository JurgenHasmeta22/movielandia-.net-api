using System;
using System.Collections.Generic;

namespace movielandia_.net_api.Models.Domain
{
    public class ActorReview
    {
        public int Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public float? Rating { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public int UserId { get; set; }
        public int ActorId { get; set; }
        
        // Navigation properties
        public virtual User User { get; set; } = null!;
        public virtual Actor Actor { get; set; } = null!;
        public virtual ICollection<UpvoteActorReview> Upvotes { get; set; }
        public virtual ICollection<DownvoteActorReview> Downvotes { get; set; }

        public ActorReview()
        {
            Upvotes = new HashSet<UpvoteActorReview>();
            Downvotes = new HashSet<DownvoteActorReview>();
        }
    }
}