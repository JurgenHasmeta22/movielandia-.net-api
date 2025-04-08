namespace movielandia_.net_api.Models.Domain
{
    public class SerieGenre
    {
        public int Id { get; set; }
        public int SerieId { get; set; }
        public int GenreId { get; set; }
        
        // Navigation properties
        public virtual Serie Serie { get; set; }
        public virtual Genre Genre { get; set; }
    }
}