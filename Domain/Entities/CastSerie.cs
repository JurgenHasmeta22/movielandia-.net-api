namespace movielandia_.net_api.Domain.Entities
{
    public class CastSerie
    {
        public int Id { get; set; }
        public int SerieId { get; set; }
        public int ActorId { get; set; }

        // Collections
        public virtual required Serie Serie { get; set; }
        public virtual required Actor Actor { get; set; }
    }
}
