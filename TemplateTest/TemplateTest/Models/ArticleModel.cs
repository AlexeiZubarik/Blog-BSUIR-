using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using TemplateTest.Controllers;
using TemplateTest.Repository;

namespace TemplateTest.Models
{
    public class ArticleModel
    {
        private readonly PostModel post;
        private readonly ICollection<string> comments;

        public ArticleModel()
        {                                  
        }

        public ArticleModel(PostModel post, ICollection<string> comments)
        {
            this.post = post;
            this.comments = comments;
        }

        public PostModel Post
        {
            get { return post; }
        }

        public ICollection<string> Comments
        {
            get { return comments; }
        }

        public AddCommentModel NewComment { get; set; }
    }
}