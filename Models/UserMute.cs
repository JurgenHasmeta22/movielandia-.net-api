namespace movielandia_.net_api.Models;

public class UserMute
{
    public int Id { get; set; }
    public DateTime MutedAt { get; set; }
    public DateTime? ExpiresAt { get; set; }
    public required string Reason { get; set; }

    // FK Keys
    public int MutedUserId { get; set; }
    public int ModeratorId { get; set; }

    // Relations
    public required User MutedUser { get; set; }
    public required User Moderator { get; set; }
}
