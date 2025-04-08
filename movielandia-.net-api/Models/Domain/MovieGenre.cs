namespace movielandia_.net_api.Models.Domain
{
    public class MovieGenre
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int GenreId { get; set; }
        
        // Navigation properties
        public virtual Movie Movie { get; set; }
        public virtual Genre Genre { get; set; }
    }
}