using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateTest.Models
{
    public class PostModel
    {
        private readonly string title, body;
        private readonly DateTime dateCreated;
        private readonly int countComments;

        public PostModel(string title, string body, DateTime dateCreated)
        {
            this.title = title;
            this.body = body;
            this.dateCreated = dateCreated;
          //  this.countComments = countComments;
        }

        public string Title
        {
            get { return title; }
        }

        public string Body
        {
            get { return body; }
        }

        public DateTime DateCreated
        {
            get { return dateCreated; }
        }

        public int CountComments
        {
            get { return countComments; }
        }
    }
}