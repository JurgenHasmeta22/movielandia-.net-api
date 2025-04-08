namespace movielandia_.net_api.Models.Domain
{
    public class UpvoteCrewReview
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CrewId { get; set; }
        public int CrewReviewId { get; set; }
        
        // Navigation properties
        public virtual User User { get; set; }
        public virtual Crew Crew { get; set; }
        public virtual CrewReview CrewReview { get; set; }
    }
}