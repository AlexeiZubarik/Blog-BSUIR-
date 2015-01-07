using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TemplateTest.Models;
using TemplateTest.Repository;

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
            var readers = new DataReaders();
            return View(readers.GetArticleModel(title));
        }

        [HttpPost]
        [Authorize(Users = "Megan")]
        public ActionResult Index(ArticleModel model)
        {
            var  title = "This is my first title";
            if(model.NewComment != null && ModelState.IsValid)
            {
                var readers = new DataReaders();
                readers.AddComment(title, model.NewComment.Comment);
                ModelState.Clear();
                return View(readers.GetArticleModel(title));
            }
            
            return View(model);
        }
    }
}
