using System;
using System.Collections.Generic;

namespace movielandia_.net_api.Models.Domain
{
    public class Season
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PhotoSrc { get; set; }
        public string PhotoSrcProd { get; set; }
        public string TrailerSrc { get; set; }
        public string Description { get; set; }
        public DateTime? DateAired { get; set; }
        public float RatingImdb { get; set; }
        public int SerieId { get; set; }

        // Navigation properties for relationships
        public virtual Serie Serie { get; set; }
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