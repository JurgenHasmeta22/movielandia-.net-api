namespace movielandia_.net_api.Domain.Entities
{
    public class UserCrewFavorite
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CrewId { get; set; }

        // Collections
        public virtual required User User { get; set; }
        public virtual required Crew Crew { get; set; }
    }
}
