using System.Collections.Generic;

namespace movielandia_.net_api.Models.Domain
{
    public class Crew
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string PhotoSrc { get; set; }
        public string Role { get; set; }
        public string PhotoSrcProd { get; set; }
        public string Description { get; set; }
        public string Debut { get; set; }

        // Navigation properties for relationships
        public virtual ICollection<CrewMovie> ProducedMovies { get; set; }
        public virtual ICollection<CrewSerie> ProducedSeries { get; set; }
        public virtual ICollection<CrewReview> Reviews { get; set; }
        public virtual ICollection<UserCrewRating> UsersWhoRatedIt { get; set; }
        public virtual ICollection<UserCrewFavorite> UsersWhoBookmarkedIt { get; set; }
        public virtual ICollection<UpvoteCrewReview> UpvoteCrewReviews { get; set; }
        public virtual ICollection<DownvoteCrewReview> DownvoteCrewReviews { get; set; }

        public Crew()
        {
            ProducedMovies = new HashSet<CrewMovie>();
            ProducedSeries = new HashSet<CrewSerie>();
            Reviews = new HashSet<CrewReview>();
            UsersWhoRatedIt = new HashSet<UserCrewRating>();
            UsersWhoBookmarkedIt = new HashSet<UserCrewFavorite>();
            UpvoteCrewReviews = new HashSet<UpvoteCrewReview>();
            DownvoteCrewReviews = new HashSet<DownvoteCrewReview>();
        }
    }
}