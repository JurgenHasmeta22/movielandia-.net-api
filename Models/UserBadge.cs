namespace movielandia_.net_api.Models;

public class UserBadge
{
    public int Id { get; set; }
    public DateTime AwardedAt { get; set; }
    public required string Reason { get; set; }

    // FK Keys
    public int UserId { get; set; }
    public int RankId { get; set; }

    // Relations
    public required User User { get; set; }
    public required UserRank Rank { get; set; }
}
