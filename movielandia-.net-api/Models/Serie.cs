using System;
using System.Collections.Generic;

namespace movielandia_.net_api.Models.Domain
{
    public class Serie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PhotoSrc { get; set; }
        public string PhotoSrcProd { get; set; }
        public string TrailerSrc { get; set; }
        public string Description { get; set; }
        public DateTime? DateAired { get; set; }
        public float RatingImdb { get; set; }

        // Navigation properties for relationships
        public virtual ICollection<CastSerie> Cast { get; set; }
        public virtual ICollection<CrewSerie> Crew { get; set; }
        public virtual ICollection<Season> Seasons { get; set; }
        public virtual ICollection<SerieReview> Reviews { get; set; }
        public virtual ICollection<SerieGenre> Genres { get; set; }
        public virtual ICollection<UserSerieFavorite> UsersWhoBookmarkedIt { get; set; }
        public virtual ICollection<UserSerieRating> UsersWhoRatedIt { get; set; }
        public virtual ICollection<UpvoteSerieReview> UpvoteSerieReviews { get; set; }
        public virtual ICollection<DownvoteSerieReview> DownvoteSerieReviews { get; set; }

        public Serie()
        {
            Cast = new HashSet<CastSerie>();
            Crew = new HashSet<CrewSerie>();
            Seasons = new HashSet<Season>();
            Reviews = new HashSet<SerieReview>();
            Genres = new HashSet<SerieGenre>();
            UsersWhoBookmarkedIt = new HashSet<UserSerieFavorite>();
            UsersWhoRatedIt = new HashSet<UserSerieRating>();
            UpvoteSerieReviews = new HashSet<UpvoteSerieReview>();
            DownvoteSerieReviews = new HashSet<DownvoteSerieReview>();
        }
    }
}