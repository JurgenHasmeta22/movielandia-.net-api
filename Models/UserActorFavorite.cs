namespace movielandia_.net_api.Models
{
    public class UserActorFavorite
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ActorId { get; set; }

        // Collections
        public virtual required User User { get; set; }
        public virtual required Actor Actor { get; set; }
    }
}
