namespace movielandia_.net_api.Models.Domain
{
    public class UserEpisodeFavorite
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int EpisodeId { get; set; }
        
        // Navigation properties
        public virtual User User { get; set; }
        public virtual Episode Episode { get; set; }
    }
}