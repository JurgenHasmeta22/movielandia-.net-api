namespace movielandia_.net_api.Models
{
    public class UserEpisodeRating
    {
        public int Id { get; set; }
        public float Rating { get; set; }
        public int UserId { get; set; }
        public int EpisodeId { get; set; }

        // Collections
        public virtual required User User { get; set; }
        public virtual required Episode Episode { get; set; }
    }
}
