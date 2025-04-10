namespace movielandia_.net_api.Models
{
    public class UserSerieFavorite
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SerieId { get; set; }

        // Navigation properties
        public virtual required User User { get; set; }
        public virtual required Serie Serie { get; set; }
    }
}
