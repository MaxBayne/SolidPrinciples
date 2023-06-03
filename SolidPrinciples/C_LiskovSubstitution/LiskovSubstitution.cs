using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.C_LiskovSubstitution
{
    /// <summary>
    /// Base Class Object can Represent any Children Classes Without any errors
    /// </summary>
    public class LiskovSubstitution
    {

        public LiskovSubstitution()
        {
            Post post;

            post = new Post();
            post = new SimplePost();
            post = new LinkPost();
            post = new MentionPost();

        }

        public class Post
        {
            public string Name { get; set; }

            public virtual string CreatePost()
            {
                return "Base Post";
            }
        }

        public class SimplePost:Post
        {
            public override string CreatePost()
            {
                return "Simple Post";
            }
        }

        public class LinkPost : Post
        {
            public override string CreatePost()
            {
                return "Link Post";
            }
        }

        public class MentionPost : Post
        {
            public override string CreatePost()
            {
                return "Mention Post";
            }
        }
    }
}
