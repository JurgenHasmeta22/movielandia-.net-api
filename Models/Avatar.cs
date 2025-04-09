namespace movielandia_.net_api.Models.Domain
{
    public class Avatar
    {
        public int Id { get; set; }
        public required string PhotoSrc { get; set; }
        public int UserId { get; set; }

        // Navigation properties
        public required virtual User User { get; set; }
    }
}
