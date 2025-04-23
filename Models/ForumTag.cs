namespace movielandia_.net_api.Models
{
    public class ForumTag
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;

        // Collections
        public virtual ICollection<ForumTopic> Topics { get; set; }

        public ForumTag()
        {
            Topics = new HashSet<ForumTopic>();
        }
    }
}
