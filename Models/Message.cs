namespace movielandia_.net_api.Models
{
    public class Message
    {
        public int Id { get; set; }
        public required string Text { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Read { get; set; } = false;
        public DateTime? EditedAt { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public int InboxId { get; set; }

        // Collections
        public virtual required User Receiver { get; set; }
        public virtual required User Sender { get; set; }
        public virtual required Inbox Inbox { get; set; }
    }
}
