namespace movielandia_.net_api.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string PhotoSrc { get; set; }
        public string PhotoSrcProd { get; set; }
        public string Description { get; set; }
        public string Debut { get; set; }

        // Navigation properties for relationships
        public virtual ICollection<CastMovie> StarredMovies { get; set; }
        public virtual ICollection<CastSerie> StarredSeries { get; set; }
        public virtual ICollection<ActorReview> Reviews { get; set; }
        public virtual ICollection<UserActorRating> UsersWhoRatedIt { get; set; }
        public virtual ICollection<UserActorFavorite> UsersWhoBookmarkedIt { get; set; }
        public virtual ICollection<UpvoteActorReview> UpvoteActorReviews { get; set; }
        public virtual ICollection<DownvoteActorReview> DownvoteActorReviews { get; set; }

        public Actor()
        {
            Fullname = string.Empty;
            PhotoSrc = string.Empty;
            PhotoSrcProd = string.Empty;
            Description = string.Empty;
            Debut = string.Empty;
            StarredMovies = new HashSet<CastMovie>();
            StarredSeries = new HashSet<CastSerie>();
            Reviews = new HashSet<ActorReview>();
            UsersWhoRatedIt = new HashSet<UserActorRating>();
            UsersWhoBookmarkedIt = new HashSet<UserActorFavorite>();
            UpvoteActorReviews = new HashSet<UpvoteActorReview>();
            DownvoteActorReviews = new HashSet<DownvoteActorReview>();
        }
    }
}
