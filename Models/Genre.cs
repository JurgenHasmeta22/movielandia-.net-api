namespace movielandia_.net_api.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Collections for relationships
        public virtual ICollection<MovieGenre> Movies { get; set; }
        public virtual ICollection<SerieGenre> Series { get; set; }
        public virtual ICollection<UserGenreFavorite> UsersWhoBookmarkedIt { get; set; }

        public Genre()
        {
            Name = string.Empty;
            Movies = new HashSet<MovieGenre>();
            Series = new HashSet<SerieGenre>();
            UsersWhoBookmarkedIt = new HashSet<UserGenreFavorite>();
        }
    }
}
