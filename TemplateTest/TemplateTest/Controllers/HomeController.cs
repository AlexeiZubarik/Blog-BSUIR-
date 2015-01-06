using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TemplateTest.Models;
using TemplateTest.Repository;

namespace TemplateTest.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    var model = new ArticleModel();
        //    return View(model);
        //}
        [HttpGet]
        public ActionResult Index(string title)
        {
            if(title == null)
            {
                title = "This is my first title";
            }
            var readers = new DataReaders();
            return View(readers.GetArticleModel(title));
        }
        [HttpPost]
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
