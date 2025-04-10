using System;

namespace movielandia_.net_api.Models;

public class UserReport
{
    public int Id { get; set; }
    public required string ReportType { get; set; }
    public required string Reason { get; set; }
    public required string Description { get; set; }
    public required string Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? ResolvedAt { get; set; }

    // FK Keys
    public int ReporterId { get; set; }
    public int ReportedUserId { get; set; }
    public int? ModeratorId { get; set; }

    // Relations
    public required User Reporter { get; set; }
    public required User ReportedUser { get; set; }
    public required User Moderator { get; set; }
}
