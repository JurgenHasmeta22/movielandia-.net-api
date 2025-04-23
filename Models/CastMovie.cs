namespace movielandia_.net_api.Models
{
    public class CastMovie
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int ActorId { get; set; }

        // Collections
        public virtual Movie? Movie { get; set; }
        public virtual Actor? Actor { get; set; }
    }
}
