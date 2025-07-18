namespace movielandia_.net_api.Models
{
    public class SerieGenre
    {
        public int Id { get; set; }
        public int SerieId { get; set; }
        public int GenreId { get; set; }

        // Collections
        public virtual required Serie Serie { get; set; }
        public virtual required Genre Genre { get; set; }
    }
}
