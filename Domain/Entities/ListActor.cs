namespace movielandia_.net_api.Domain.Entities;

public class ListActor
{
    public int Id { get; set; }
    public DateTime AddedAt { get; set; }
    public required string Notes { get; set; }

    // FK Keys
    public int ListId { get; set; }
    public int ActorId { get; set; }

    // Relations
    public required List List { get; set; }
    public required Actor Actor { get; set; }
}
