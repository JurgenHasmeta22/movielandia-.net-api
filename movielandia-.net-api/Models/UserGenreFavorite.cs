namespace movielandia_.net_api.Models.Domain
{
    public class UserGenreFavorite
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int GenreId { get; set; }
        
        // Navigation properties
        public virtual required User User { get; set; }
        public virtual required Genre Genre { get; set; }
    }
}