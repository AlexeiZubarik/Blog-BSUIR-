using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateTest.Repository.Domain
{
    public class Post
    {
        public int PostID { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public DateTime DateCreated { get; set; }

        public virtual ISet<Comment> Comments { get; set; }
    }
}