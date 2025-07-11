namespace movielandia_.net_api.Models;

public class ListCrew
{
    public int Id { get; set; }
    public DateTime AddedAt { get; set; }
    public required string Notes { get; set; }

    // FK Keys
    public int ListId { get; set; }
    public int CrewId { get; set; }

    // Relations
    public required List List { get; set; }
    public required Crew Crew { get; set; }
}
