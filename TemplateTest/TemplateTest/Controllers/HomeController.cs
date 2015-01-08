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
            //FormsAuthentication.SetAuthCookie("Alexei", true);
            //var cookie = FormsAuthentication.GetAuthCookie("Alexei", true);
            //Response.Cookies.Add(cookie);

            if(title == null)
            {
                title = "This is my second title";
            }

            var model = new ArticleModel();
            var reader = new DataBase();
            model = reader.GetModel(title);
            reader.SaveTitle(title);
            
            return View(model);           
        }

        [HttpPost]
        //[Authorize(Users = "Alexei")]
        [ValidateInput(false)]
        public ActionResult Index(ArticleModel model)
        {
            //var title = model.Post.Title;
            var  title = "This is my second title";
            if(model.NewComment != null && ModelState.IsValid)
            {
                var save = new DataBase();
                save.SaveComment(model, title);
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
