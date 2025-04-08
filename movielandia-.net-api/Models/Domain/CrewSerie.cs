namespace movielandia_.net_api.Models.Domain
{
    public class CrewSerie
    {
        public int Id { get; set; }
        public int SerieId { get; set; }
        public int CrewId { get; set; }
        
        // Navigation properties
        public required virtual Serie Serie { get; set; }
        public required virtual Crew Crew { get; set; }
    }
}