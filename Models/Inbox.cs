namespace movielandia_.net_api.Models
{
    public class Inbox
    {
        public int Id { get; set; }

        // Collections
        public virtual ICollection<UserInbox> Participants { get; set; }
        public virtual ICollection<Message> Messages { get; set; }

        public Inbox()
        {
            Participants = new HashSet<UserInbox>();
            Messages = new HashSet<Message>();
        }
    }
}
