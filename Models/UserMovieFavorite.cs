namespace movielandia_.net_api.Models
{
    public class UserMovieFavorite
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MovieId { get; set; }

        // Collections
        public virtual required User User { get; set; }
        public virtual required Movie Movie { get; set; }
    }
}
