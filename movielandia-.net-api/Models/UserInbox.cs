namespace movielandia_.net_api.Models.Domain
{
    public class UserInbox
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int InboxId { get; set; }

        // Navigation properties
        public virtual required User User { get; set; }
        public virtual required Inbox Inbox { get; set; }
    }
}
