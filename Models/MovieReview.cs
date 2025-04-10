using System;
using System.Collections.Generic;

namespace movielandia_.net_api.Models
{
    public class MovieReview
    {
        public int Id { get; set; }
        public required string Content { get; set; }
        public float? Rating { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public int UserId { get; set; }
        public int MovieId { get; set; }

        // Navigation properties
        public required virtual User User { get; set; }
        public virtual required Movie Movie { get; set; }
        public virtual ICollection<UpvoteMovieReview> Upvotes { get; set; }
        public virtual ICollection<DownvoteMovieReview> Downvotes { get; set; }

        public MovieReview()
        {
            Upvotes = new HashSet<UpvoteMovieReview>();
            Downvotes = new HashSet<DownvoteMovieReview>();
        }
    }
}
