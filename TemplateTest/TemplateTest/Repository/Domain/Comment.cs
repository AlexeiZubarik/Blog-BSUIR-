using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateTest.Repository.Domain
{
    public class Comment
    {
        public int CommentID { get; set; }

        public int PostID { get; set; }

        public Post Post { get; set; }

        public string Body { get; set; }

        public DateTime DateCreated { get; set; }
    }
}