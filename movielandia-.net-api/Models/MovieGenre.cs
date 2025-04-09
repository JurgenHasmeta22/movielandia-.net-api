namespace movielandia_.net_api.Models.Domain
{
    public class MovieGenre
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int GenreId { get; set; }

        // Navigation properties
        public virtual required Movie Movie { get; set; }
        public virtual required Genre Genre { get; set; }
    }
}
