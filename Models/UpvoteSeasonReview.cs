namespace movielandia_.net_api.Models
{
    public class UpvoteSeasonReview
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SeasonId { get; set; }
        public int SeasonReviewId { get; set; }

        // Collections
        public virtual required User User { get; set; }
        public virtual required Season Season { get; set; }
        public virtual required SeasonReview SeasonReview { get; set; }
    }
}
