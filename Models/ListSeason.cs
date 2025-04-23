namespace movielandia_.net_api.Models;

public class ListSeason
{
    public int Id { get; set; }
    public DateTime AddedAt { get; set; }
    public required string Notes { get; set; }

    // FK Keys
    public int ListId { get; set; }
    public int SeasonId { get; set; }

    // Relations
    public required List List { get; set; }
    public required Season Season { get; set; }
}
