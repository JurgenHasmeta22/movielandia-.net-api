namespace movielandia_.net_api.Models.Domain
{
    public class CastSerie
    {
        public int Id { get; set; }
        public int SerieId { get; set; }
        public int ActorId { get; set; }
        
        // Navigation properties
        public virtual Serie Serie { get; set; }
        public virtual Actor Actor { get; set; }
    }
}