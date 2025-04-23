namespace movielandia_.net_api.Models;

public class UserBlock
{
    public int Id { get; set; }
    public DateTime BlockedAt { get; set; }
    public required string Reason { get; set; }

    // FK Keys
    public int BlockerId { get; set; }
    public int BlockedId { get; set; }

    // Relations
    public required User Blocker { get; set; }
    public required User Blocked { get; set; }
}
