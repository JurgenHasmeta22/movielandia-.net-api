namespace movielandia_.net_api.Models
{
    public class UpvoteCrewReview
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CrewId { get; set; }
        public int CrewReviewId { get; set; }

        // Collections
        public virtual required User User { get; set; }
        public virtual required Crew Crew { get; set; }
        public virtual required CrewReview CrewReview { get; set; }
    }
}
