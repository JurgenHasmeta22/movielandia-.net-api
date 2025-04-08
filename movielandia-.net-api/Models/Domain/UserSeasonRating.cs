namespace movielandia_.net_api.Models.Domain
{
    public class UserSeasonRating
    {
        public int Id { get; set; }
        public float Rating { get; set; }
        public int UserId { get; set; }
        public int SeasonId { get; set; }
        
        // Navigation properties
        public virtual required User User { get; set; }
        public virtual required Season Season { get; set; }
    }
}