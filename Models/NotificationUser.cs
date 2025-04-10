using System;

namespace movielandia_.net_api.Models;

public class NotificationUser
{
    public int Id { get; set; }
    public bool IsRead { get; set; }
    public DateTime? ReadAt { get; set; }

    // FK Keys
    public int UserId { get; set; }
    public int NotificationId { get; set; }

    // Relations
    public required User User { get; set; }
    public required Notification Notification { get; set; }
}
