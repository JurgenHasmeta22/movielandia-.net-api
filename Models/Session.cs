namespace movielandia_.net_api.Models
{
    public class Session
    {
        public required string Id { get; set; }
        public required string SessionToken { get; set; }
        public DateTime Expires { get; set; }
        public int UserId { get; set; }

        // Collections
        public virtual required User User { get; set; }
    }
}
