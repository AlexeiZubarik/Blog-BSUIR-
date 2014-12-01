using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace TemplateTest.Models
{
    public class ArticleModel
    {
        public ArticleModel()
        {
            Title = "This is an article title";
            Body = "Donec eget lacus eros, et blandit odio. Maecenas et urna vitae sapien dictum dapibus. Aliquam id sem metus. Aenean sapien felis, congue porttitor elementum quis, pretium sit amet urna";
            Date = DateTime.Now;
            Author = "Alexei Zubarik";
            Category = "Home";
            Likes = new Collection<LikeModel>();
            Comments = new Collection<CommentItemModel>();
        }

        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }

        public ICollection<LikeModel> Likes { get; set; }
        public ICollection<CommentItemModel> Comments { get; set; }
    }
}