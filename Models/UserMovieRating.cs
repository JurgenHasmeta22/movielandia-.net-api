namespace movielandia_.net_api.Models
{
    public class UserMovieRating
    {
        public int Id { get; set; }
        public float Rating { get; set; }
        public int UserId { get; set; }
        public int MovieId { get; set; }

        // Collections
        public virtual required User User { get; set; }
        public virtual required Movie Movie { get; set; }
    }
}
