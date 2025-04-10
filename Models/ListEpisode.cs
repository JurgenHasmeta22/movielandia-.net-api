using System;

namespace movielandia_.net_api.Models;

public class ListEpisode
{
    public int Id { get; set; }
    public DateTime AddedAt { get; set; }
    public required string Notes { get; set; }

    // FK Keys
    public int ListId { get; set; }
    public int EpisodeId { get; set; }

    // Relations
    public required List List { get; set; }
    public required Episode Episode { get; set; }
}
