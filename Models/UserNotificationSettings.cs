namespace movielandia_.net_api.Models;

public class UserNotificationSettings
{
    public int Id { get; set; }
    public bool EmailNotifications { get; set; }
    public bool PushNotifications { get; set; }
    public bool ForumNotifications { get; set; }
    public bool ReviewNotifications { get; set; }
    public bool FollowerNotifications { get; set; }
    public bool MessageNotifications { get; set; }
    public DateTime UpdatedAt { get; set; }

    // FK Keys
    public int UserId { get; set; }

    // Relations
    public required User User { get; set; }
}
