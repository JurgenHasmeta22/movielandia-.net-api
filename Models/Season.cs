using System;
using System.Collections.Generic;

namespace movielandia_.net_api.Models
{
    public class Season
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string PhotoSrc { get; set; } = string.Empty;
        public string PhotoSrcProd { get; set; } = string.Empty;
        public string TrailerSrc { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime? DateAired { get; set; }
        public float RatingImdb { get; set; }
        public int SerieId { get; set; }

        // Navigation properties for relationships
        public virtual Serie Serie { get; set; } = null!;
        public virtual ICollection<Episode> Episodes { get; set; }
        public virtual ICollection<UserSeasonFavorite> UsersWhoBookmarkedIt { get; set; }
        public virtual ICollection<UserSeasonRating> UsersWhoRatedIt { get; set; }
        public virtual ICollection<SeasonReview> Reviews { get; set; }
        public virtual ICollection<UpvoteSeasonReview> UpvoteSeasonReviews { get; set; }
        public virtual ICollection<DownvoteSeasonReview> DownvoteSeasonReviews { get; set; }

        public Season()
        {
            Episodes = new HashSet<Episode>();
            UsersWhoBookmarkedIt = new HashSet<UserSeasonFavorite>();
            UsersWhoRatedIt = new HashSet<UserSeasonRating>();
            Reviews = new HashSet<SeasonReview>();
            UpvoteSeasonReviews = new HashSet<UpvoteSeasonReview>();
            DownvoteSeasonReviews = new HashSet<DownvoteSeasonReview>();
        }
    }
}
