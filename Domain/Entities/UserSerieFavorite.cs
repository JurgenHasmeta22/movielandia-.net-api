namespace movielandia_.net_api.Domain.Entities
{
    public class UserSerieFavorite
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SerieId { get; set; }

        // Collections
        public virtual required User User { get; set; }
        public virtual required Serie Serie { get; set; }
    }
}
