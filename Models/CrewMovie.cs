namespace movielandia_.net_api.Models
{
    public class CrewMovie
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int CrewId { get; set; }

        // Collections
        public required virtual Movie Movie { get; set; }
        public virtual required Crew Crew { get; set; }
    }
}
