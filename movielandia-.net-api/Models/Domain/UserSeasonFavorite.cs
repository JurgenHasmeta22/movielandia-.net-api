namespace movielandia_.net_api.Models.Domain
{
    public class UserSeasonFavorite
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SeasonId { get; set; }
        
        // Navigation properties
        public virtual User User { get; set; }
        public virtual Season Season { get; set; }
    }
}