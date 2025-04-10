using System;

namespace movielandia_.net_api.Models;

public class ContentChangeLog
{
    public int Id { get; set; }
    public required string EntityType { get; set; }
    public int EntityId { get; set; }
    public required string Field { get; set; }
    public required string OldValue { get; set; }
    public required string NewValue { get; set; }
    public DateTime ChangedAt { get; set; }
    public required string IpAddress { get; set; }
    public required string UserAgent { get; set; }

    // FK Keys
    public int UserId { get; set; }

    // Relations
    public required User User { get; set; }
}
