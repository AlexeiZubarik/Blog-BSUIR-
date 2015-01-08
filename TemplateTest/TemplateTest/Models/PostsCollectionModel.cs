using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using TemplateTest.Repository;

namespace TemplateTest.Models
{
    public class PostsCollectionModel
    {
        public PostsCollectionModel()
        {
            Items = new Collection<PostModel>();
            
            using (var ctx = new EFContext())
            {
                for (int i = 0; i < ctx.Posts.Count(); i++)
                {
                    var post = ctx.Posts.Where(p => p.PostID == 1).FirstOrDefault();
                    var postModel = new PostModel(post.Title, post.Body, post.DateCreated/*,post.Comments.Count()*/);
                    Items.Add(postModel);
                }
            }
        }
        public ICollection<PostModel> Items { get; set; }
    }
}