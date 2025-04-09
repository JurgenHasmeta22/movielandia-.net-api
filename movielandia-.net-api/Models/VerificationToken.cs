using System;

namespace movielandia_.net_api.Models.Domain
{
    public class VerificationToken
    {
        public required string Identifier { get; set; }
        public required string Token { get; set; }
        public DateTime Expires { get; set; }
    }
}