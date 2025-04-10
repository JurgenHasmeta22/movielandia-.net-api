using System;

namespace movielandia_.net_api.Models;

public class ContentHistory
{
    public int Id { get; set; }
    public required string EntityType { get; set; }
    public int EntityId { get; set; }
    public required string Action { get; set; }
    public required string Changes { get; set; }
    public required string Reason { get; set; }
    public DateTime CreatedAt { get; set; }

    // FK Keys
    public int UserId { get; set; }

    // Relations
    public required User User { get; set; }
}
