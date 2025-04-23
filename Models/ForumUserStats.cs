namespace movielandia_.net_api.Models;

public class ForumUserStats
{
    public int Id { get; set; }
    public int TotalPosts { get; set; }
    public int TotalTopics { get; set; }
    public int TotalReplies { get; set; }
    public int TopicsViewed { get; set; }
    public DateTime LastActive { get; set; }
    public int Reputation { get; set; }

    // FK Keys
    public int UserId { get; set; }

    // Relations
    public required User User { get; set; }
}
