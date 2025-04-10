using System;
using System.Collections.Generic;

namespace movielandia_.net_api.Models;

public class List
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public bool IsPublic { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    // FK Keys
    public int UserId { get; set; }

    // Relations
    public required User User { get; set; }
    public required ICollection<ListMovie> Movies { get; set; }
    public required ICollection<ListSerie> Series { get; set; }
    public required ICollection<ListSeason> Seasons { get; set; }
    public required ICollection<ListEpisode> Episodes { get; set; }
    public required ICollection<ListActor> Actors { get; set; }
    public required ICollection<ListCrew> Crew { get; set; }
}
