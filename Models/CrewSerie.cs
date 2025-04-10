namespace movielandia_.net_api.Models
{
    public class CrewSerie
    {
        public int Id { get; set; }
        public int SerieId { get; set; }
        public int CrewId { get; set; }

        // Navigation properties
        public required virtual Serie Serie { get; set; }
        public virtual required Crew Crew { get; set; }
    }
}
