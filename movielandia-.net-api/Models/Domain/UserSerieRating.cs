namespace movielandia_.net_api.Models.Domain
{
    public class UserSerieRating
    {
        public int Id { get; set; }
        public float Rating { get; set; }
        public int UserId { get; set; }
        public int SerieId { get; set; }
        
        // Navigation properties
        public virtual User User { get; set; }
        public virtual Serie Serie { get; set; }
    }
}