namespace movielandia_.net_api.Models.Domain
{
    public class Account
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Provider { get; set; }
        public string RefreshToken { get; set; }
        public string AccessToken { get; set; }
        public int? ExpiresAt { get; set; }
        public string TokenType { get; set; }
        public string Scope { get; set; }
        public string IdToken { get; set; }
        public string SessionState { get; set; }
        public int UserId { get; set; }
        public string ProviderAccountId { get; set; }

        // Navigation properties
        public virtual User User { get; set; }
    }
}