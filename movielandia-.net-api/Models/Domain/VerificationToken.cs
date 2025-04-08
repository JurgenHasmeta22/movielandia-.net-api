using System;

namespace movielandia_.net_api.Models.Domain
{
    public class VerificationToken
    {
        public string Identifier { get; set; }
        public string Token { get; set; }
        public DateTime Expires { get; set; }
    }
}