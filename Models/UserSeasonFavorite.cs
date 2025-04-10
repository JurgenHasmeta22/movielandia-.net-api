namespace movielandia_.net_api.Models
{
    public class UserSeasonFavorite
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SeasonId { get; set; }

        // Navigation properties
        public virtual required User User { get; set; }
        public virtual required Season Season { get; set; }
    }
}
