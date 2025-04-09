using System;
using System.Collections.Generic;

namespace movielandia_.net_api.Models.Domain
{
    public class SeasonReview
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public float? Rating { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public int UserId { get; set; }
        public int SeasonId { get; set; }
        
        // Navigation properties
        public virtual User User { get; set; }
        public virtual Season Season { get; set; }
        public virtual ICollection<UpvoteSeasonReview> Upvotes { get; set; }
        public virtual ICollection<DownvoteSeasonReview> Downvotes { get; set; }

        public SeasonReview()
        {
            Upvotes = new HashSet<UpvoteSeasonReview>();
            Downvotes = new HashSet<DownvoteSeasonReview>();
        }
    }
}