namespace movielandia_.net_api.Models;

public class UserActivity
{
    public int Id { get; set; }
    public required string ActivityType { get; set; }
    public required string Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public required string EntityType { get; set; }
    public int? EntityId { get; set; }
    public required string Metadata { get; set; }

    // FK Keys
    public int UserId { get; set; }

    // Relations
    public required User User { get; set; }
}
