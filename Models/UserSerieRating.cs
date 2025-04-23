namespace movielandia_.net_api.Models
{
    public class UserSerieRating
    {
        public int Id { get; set; }
        public float Rating { get; set; }
        public int UserId { get; set; }
        public int SerieId { get; set; }

        // Collections
        public virtual required User User { get; set; }
        public virtual required Serie Serie { get; set; }
    }
}
