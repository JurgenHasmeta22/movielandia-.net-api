namespace movielandia_.net_api.Models.Domain
{
    public class UserActorRating
    {
        public int Id { get; set; }
        public float Rating { get; set; }
        public int UserId { get; set; }
        public int ActorId { get; set; }

        // Navigation properties
        public virtual required User User { get; set; }
        public virtual required Actor Actor { get; set; }
    }
}
