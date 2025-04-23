namespace movielandia_.net_api.Models;

public class Notification
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Content { get; set; }
    public required string Type { get; set; }
    public DateTime CreatedAt { get; set; }
    public required string Link { get; set; }
    public bool IsGlobal { get; set; }

    // Relations
    public required ICollection<NotificationUser> NotificationUsers { get; set; }
}
