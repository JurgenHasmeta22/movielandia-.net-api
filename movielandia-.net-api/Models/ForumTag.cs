using System.Collections.Generic;

namespace movielandia_.net_api.Models.Domain
{
    public class ForumTag
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        
        // Navigation properties
        public virtual ICollection<ForumTopic> Topics { get; set; }

        public ForumTag()
        {
            Topics = new HashSet<ForumTopic>();
        }
    }
}