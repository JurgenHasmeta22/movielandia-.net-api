namespace movielandia_.net_api.DTOs
{
    public class MovieDetailDTO : MovieDTO
    {
        public required IEnumerable<MovieGenreDTO> Genres { get; set; }
        public required IEnumerable<MovieCastDTO> Cast { get; set; }
        public required IEnumerable<MovieCrewDTO> Crew { get; set; }
        public required IEnumerable<MovieReviewDTO> Reviews { get; set; }
    }

    public class MovieGenreDTO
    {
        public int Id { get; set; }
        public int GenreId { get; set; }
        public required string Name { get; set; }
    }

    public class MovieCastDTO
    {
        public int Id { get; set; }
        public int ActorId { get; set; }
        public required string Fullname { get; set; }
        public required string PhotoSrc { get; set; }
    }

    public class MovieCrewDTO
    {
        public int Id { get; set; }
        public int CrewId { get; set; }
        public required string Fullname { get; set; }
        public required string Role { get; set; }
        public required string PhotoSrc { get; set; }
    }

    public class MovieReviewDTO
    {
        public int Id { get; set; }
        public required string Content { get; set; }
        public float? Rating { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public int UserId { get; set; }
        public required string UserName { get; set; }

        public int UpvotesCount { get; set; }
        public int DownvotesCount { get; set; }

        public bool IsUpvoted { get; set; } = false;
        public bool IsDownvoted { get; set; } = false;
    }
}
