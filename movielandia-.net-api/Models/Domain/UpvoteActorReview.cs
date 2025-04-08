namespace movielandia_.net_api.Models.Domain
{
    public class UpvoteActorReview
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ActorId { get; set; }
        public int ActorReviewId { get; set; }
        
        // Navigation properties
        public virtual User User { get; set; }
        public virtual Actor Actor { get; set; }
        public virtual ActorReview ActorReview { get; set; }
    }
}