namespace movielandia_.net_api.Models
{
    public class Account
    {
        public required string Id { get; set; }
        public required string Type { get; set; }
        public required string Provider { get; set; }
        public required string RefreshToken { get; set; }
        public required string AccessToken { get; set; }
        public int? ExpiresAt { get; set; }
        public required string TokenType { get; set; }
        public required string Scope { get; set; }
        public required string IdToken { get; set; }
        public required string SessionState { get; set; }
        public int UserId { get; set; }
        public required string ProviderAccountId { get; set; }

        // Navigation properties
        public virtual required User User { get; set; }
    }
}
