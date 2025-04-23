namespace movielandia_.net_api.Models;

public class UserFollow
{
    public int Id { get; set; }
    public DateTime FollowedAt { get; set; }

    // FK Keys
    public int FollowerId { get; set; }
    public int FollowingId { get; set; }

    // Relations
    public required User Follower { get; set; }
    public required User Following { get; set; }
}
