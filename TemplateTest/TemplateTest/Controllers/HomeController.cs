using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TemplateTest.Models;
using TemplateTest.Repository;
using TemplateTest.Repository.Domain;

namespace TemplateTest.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index(string title)
        {
            FormsAuthentication.SetAuthCookie("Alexei", true);
            //var cookie = FormsAuthentication.GetAuthCookie("Alexei", true);
            //Response.Cookies.Add(cookie);

            if(title == null)
            {
                title = "This is my first title";
            }
            using (var ctx = new EFContext())
            {
                var post = ctx.Posts.Where(p => p.Title == title).FirstOrDefault();
                var postModel = new PostModel(post.Title, post.Body, post.DateCreated, post.Comments.Count());
                var commentModel = new Collection<string>();
                if(post.Comments != null && post.Comments.Any())
                {
                    foreach (var item in post.Comments)
                    {
                        commentModel.Add(item.Body); 
                    }
                }
                return View(new ArticleModel(postModel, commentModel));
            }
            
            //var readers = new DataReaders();
            //return View(readers.GetArticleModel(title));
        }

        [HttpPost]
        [Authorize(Users = "Megan")]
        public ActionResult Index(ArticleModel model)
        {
            var  title = "This is my first title";
            if(model.NewComment != null && ModelState.IsValid)
            {
                using(var ctx = new EFContext())
                {
                    var post = ctx.Posts.Where(p => p.Title == title).FirstOrDefault();
                    if(post != null)
                    {
                        ctx.Comments.Add(new Comment() {Body = model.NewComment.Comment, PostID = post.PostID});
                        ctx.SaveChanges();
                    }
                }
                //var readers = new DataReaders();
                //readers.AddComment(title, model.NewComment.Comment);
                ModelState.Clear();
                return RedirectToAction("Index", new { title = title});
            }
            
            return View(model);
        }

        public ActionResult AllPosts()
        {
            var model = new PostsCollectionModel();
            return View(model);            
        }
    }
}
