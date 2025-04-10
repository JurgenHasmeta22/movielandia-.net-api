using System;

namespace movielandia_.net_api.Models;

public class ListSerie
{
    public int Id { get; set; }
    public DateTime AddedAt { get; set; }
    public required string Notes { get; set; }

    // FK Keys
    public int ListId { get; set; }
    public int SerieId { get; set; }

    // Relations
    public required List List { get; set; }
    public required Serie Serie { get; set; }
}
