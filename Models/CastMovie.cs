namespace movielandia_.net_api.Models.Domain
{
    public class CastMovie
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int ActorId { get; set; }

        // Navigation properties
        public required virtual Movie Movie { get; set; }
        public virtual required Actor Actor { get; set; }
    }
}
