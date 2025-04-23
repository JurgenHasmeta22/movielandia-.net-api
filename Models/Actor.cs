namespace movielandia_.net_api.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public required string Fullname { get; set; }
        public required string Description { get; set; }
        public string? Debut { get; set; }
        public required string PhotoSrc { get; set; }
        public required string PhotoSrcProd { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Collections
        public virtual ICollection<CastMovie> Movies { get; set; }
        public virtual ICollection<ActorReview> Reviews { get; set; }
        public virtual ICollection<UserActorFavorite> UsersWhoBookmarkedIt { get; set; }
        public virtual ICollection<UserActorRating> UsersWhoRatedIt { get; set; }
        public virtual ICollection<UpvoteActorReview> UpvoteActorReviews { get; set; }
        public virtual ICollection<DownvoteActorReview> DownvoteActorReviews { get; set; }

        public Actor()
        {
            Movies = new HashSet<CastMovie>();
            Reviews = new HashSet<ActorReview>();
            UsersWhoBookmarkedIt = new HashSet<UserActorFavorite>();
            UsersWhoRatedIt = new HashSet<UserActorRating>();
            UpvoteActorReviews = new HashSet<UpvoteActorReview>();
            DownvoteActorReviews = new HashSet<DownvoteActorReview>();
        }
    }
}
