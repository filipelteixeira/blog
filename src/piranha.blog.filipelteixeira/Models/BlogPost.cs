using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Models;

namespace piranha.blog.filipelteixeira.Models
{
    [PostType(Title = "Blog post")]
    public class BlogPost : Post<BlogPost>
    {
        /// <summary>
        /// Gets/sets the hero.
        /// </summary>
        [Region]
        public Regions.Hero Hero { get; set; }
    }
}