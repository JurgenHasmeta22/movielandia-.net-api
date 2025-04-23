namespace movielandia_.net_api.Models;

public class ListMovie
{
    public int Id { get; set; }
    public DateTime AddedAt { get; set; }
    public required string Notes { get; set; }

    // FK Keys
    public int ListId { get; set; }
    public int MovieId { get; set; }

    // Relations
    public required List List { get; set; }
    public required Movie Movie { get; set; }
}
