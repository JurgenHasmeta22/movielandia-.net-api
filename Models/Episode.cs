using System;
using System.Collections.Generic;

namespace movielandia_.net_api.Models
{
    public class Episode
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PhotoSrc { get; set; }
        public string PhotoSrcProd { get; set; }
        public string TrailerSrc { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public DateTime? DateAired { get; set; }
        public float RatingImdb { get; set; }
        public int SeasonId { get; set; }

        // Navigation properties for relationships
        public required virtual Season Season { get; set; }
        public virtual ICollection<UserEpisodeFavorite> UsersWhoBookmarkedIt { get; set; }
        public virtual ICollection<UserEpisodeRating> UsersWhoRatedIt { get; set; }
        public virtual ICollection<EpisodeReview> Reviews { get; set; }
        public virtual ICollection<UpvoteEpisodeReview> UpvoteEpisodeReviews { get; set; }
        public virtual ICollection<DownvoteEpisodeReview> DownvoteEpisodeReviews { get; set; }

        public Episode()
        {
            Title = string.Empty;
            PhotoSrc = string.Empty;
            PhotoSrcProd = string.Empty;
            TrailerSrc = string.Empty;
            Description = string.Empty;
            UsersWhoBookmarkedIt = new HashSet<UserEpisodeFavorite>();
            UsersWhoRatedIt = new HashSet<UserEpisodeRating>();
            Reviews = new HashSet<EpisodeReview>();
            UpvoteEpisodeReviews = new HashSet<UpvoteEpisodeReview>();
            DownvoteEpisodeReviews = new HashSet<DownvoteEpisodeReview>();
        }
    }
}
