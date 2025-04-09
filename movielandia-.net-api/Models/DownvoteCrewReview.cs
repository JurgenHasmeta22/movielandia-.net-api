namespace movielandia_.net_api.Models.Domain
{
    public class DownvoteCrewReview
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CrewId { get; set; }
        public int CrewReviewId { get; set; }

        // Navigation properties
        public required virtual User User { get; set; }
        public virtual required Crew Crew { get; set; }
        public virtual required CrewReview CrewReview { get; set; }
    }
}
