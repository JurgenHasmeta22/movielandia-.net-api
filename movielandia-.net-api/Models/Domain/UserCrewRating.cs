namespace movielandia_.net_api.Models.Domain
{
    public class UserCrewRating
    {
        public int Id { get; set; }
        public float Rating { get; set; }
        public int UserId { get; set; }
        public int CrewId { get; set; }
        
        // Navigation properties
        public virtual User User { get; set; }
        public virtual Crew Crew { get; set; }
    }
}