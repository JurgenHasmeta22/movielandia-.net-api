using System;

namespace movielandia_.net_api.Models;

public class UserRank
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public int MinPoints { get; set; }
    public required string IconUrl { get; set; }
    public required string Color { get; set; }

    // Relations
    public required ICollection<UserBadge> UserBadges { get; set; }
}
