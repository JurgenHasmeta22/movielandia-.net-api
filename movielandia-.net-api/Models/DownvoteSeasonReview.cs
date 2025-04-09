namespace movielandia_.net_api.Models.Domain
{
    public class DownvoteSeasonReview
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SeasonId { get; set; }
        public int SeasonReviewId { get; set; }
        
        // Navigation properties
        public required virtual User User { get; set; }
        public required virtual Season Season { get; set; }
        public required virtual SeasonReview SeasonReview { get; set; }
    }
}