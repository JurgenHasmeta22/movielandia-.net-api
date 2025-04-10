namespace movielandia_.net_api.Models
{
    public class CastSerie
    {
        public int Id { get; set; }
        public int SerieId { get; set; }
        public int ActorId { get; set; }

        // Navigation properties
        public virtual required Serie Serie { get; set; }
        public virtual required Actor Actor { get; set; }
    }
}
