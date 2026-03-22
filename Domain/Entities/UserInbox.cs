namespace movielandia_.net_api.Domain.Entities
{
    public class UserInbox
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int InboxId { get; set; }

        // Collections
        public virtual required User User { get; set; }
        public virtual required Inbox Inbox { get; set; }
    }
}
