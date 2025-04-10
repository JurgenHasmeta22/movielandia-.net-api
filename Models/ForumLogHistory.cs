using System;

namespace movielandia_.net_api.Models;

public class ForumLogHistory
{
    public int Id { get; set; }
    public required string Action { get; set; }
    public required string Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public required string IpAddress { get; set; }
    public required string UserAgent { get; set; }

    // FK Keys
    public int UserId { get; set; }
    public int? CategoryId { get; set; }
    public int? TopicId { get; set; }
    public int? PostId { get; set; }

    // Relations
    public required User User { get; set; }
    public required ForumCategory Category { get; set; }
    public required ForumTopic Topic { get; set; }
    public required ForumPost Post { get; set; }
}
