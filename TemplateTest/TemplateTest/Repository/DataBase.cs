using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using TemplateTest.Models;
using TemplateTest.Repository.Domain;

namespace TemplateTest.Repository
{
    
    public class DataBase
    {
        private string Title;

        public void SaveTitle(string title)
        {
            Title = title;  
        }

        public string GetTitle()
        {
            return Title;
        }

        public ArticleModel GetModel(string title)
        {
            var model = new ArticleModel();
            using (var ctx = new EFContext())
            {
                var post = ctx.Posts.Where(p => p.Title == title).FirstOrDefault();
                var postModel = new PostModel(post.Title, post.Body, post.DateCreated);
                var commentModel = new Collection<string>();
                if (post.Comments != null && post.Comments.Any())
                {
                    foreach (var item in post.Comments)
                    {
                        commentModel.Add(item.Body);
                    }
                }
                return model = new ArticleModel(postModel, commentModel);
            }
            
        }
        public void SaveComment(ArticleModel model,string title)
        {
            using (var ctx = new EFContext())
            {
                var post = ctx.Posts.Where(p => p.Title == title).FirstOrDefault();
                if (post != null)
                {
                    ctx.Comments.Add(new Comment() { Body = model.NewComment.Comment, PostID = post.PostID });
                    ctx.SaveChanges();
                }
            }       
        }
    }
}