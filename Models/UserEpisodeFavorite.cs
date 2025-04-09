namespace movielandia_.net_api.Models.Domain
{
    public class UserEpisodeFavorite
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int EpisodeId { get; set; }

        // Navigation properties
        public virtual required User User { get; set; }
        public virtual required Episode Episode { get; set; }
    }
}
