using System;
using System.Collections.Generic;

namespace movielandia_.net_api.Models.Domain
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PhotoSrc { get; set; }
        public string PhotoSrcProd { get; set; }
        public string TrailerSrc { get; set; }
        public int Duration { get; set; }
        public float RatingImdb { get; set; }
        public DateTime? DateAired { get; set; }
        public string Description { get; set; }

        // Navigation properties for relationships
        public virtual ICollection<CastMovie> Cast { get; set; }
        public virtual ICollection<CrewMovie> Crew { get; set; }
        public virtual ICollection<MovieGenre> Genres { get; set; }
        public virtual ICollection<MovieReview> Reviews { get; set; }
        public virtual ICollection<UserMovieFavorite> UsersWhoBookmarkedIt { get; set; }
        public virtual ICollection<UserMovieRating> UsersWhoRatedIt { get; set; }
        public virtual ICollection<UpvoteMovieReview> UpvoteMovieReviews { get; set; }
        public virtual ICollection<DownvoteMovieReview> DownvoteMovieReviews { get; set; }

        public Movie()
        {
            Cast = new HashSet<CastMovie>();
            Crew = new HashSet<CrewMovie>();
            Genres = new HashSet<MovieGenre>();
            Reviews = new HashSet<MovieReview>();
            UsersWhoBookmarkedIt = new HashSet<UserMovieFavorite>();
            UsersWhoRatedIt = new HashSet<UserMovieRating>();
            UpvoteMovieReviews = new HashSet<UpvoteMovieReview>();
            DownvoteMovieReviews = new HashSet<DownvoteMovieReview>();
        }
    }
}