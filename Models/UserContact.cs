namespace movielandia_.net_api.Models;

public class UserContact
{
    public int Id { get; set; }
    public required string ContactType { get; set; }
    public required string Value { get; set; }
    public bool IsVerified { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? VerifiedAt { get; set; }

    // FK Keys
    public int UserId { get; set; }

    // Relations
    public required User User { get; set; }
}
