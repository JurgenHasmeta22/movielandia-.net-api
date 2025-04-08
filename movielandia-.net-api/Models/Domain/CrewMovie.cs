namespace movielandia_.net_api.Models.Domain
{
    public class CrewMovie
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int CrewId { get; set; }
        
        // Navigation properties
        public required virtual Movie Movie { get; set; }
        public required virtual Crew Crew { get; set; }
    }
}