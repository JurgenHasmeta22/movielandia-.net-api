namespace movielandia_.net_api.Models.Domain
{
    public class UpvoteSeasonReview
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SeasonId { get; set; }
        public int SeasonReviewId { get; set; }
        
        // Navigation properties
        public virtual User User { get; set; }
        public virtual Season Season { get; set; }
        public virtual SeasonReview SeasonReview { get; set; }
    }
}