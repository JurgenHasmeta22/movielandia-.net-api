using System;

namespace movielandia_.net_api.Models.Domain
{
    public class Session
    {
        public string Id { get; set; }
        public string SessionToken { get; set; }
        public DateTime Expires { get; set; }
        public int UserId { get; set; }
        
        // Navigation properties
        public virtual User User { get; set; }
    }
}