using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TemplateTest.Models;

namespace TemplateTest.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    var model = new ArticleModel();
        //    return View(model);
        //}

        public ActionResult Index(string id)
        {
            var model = new ArticleModel();
            return View(model);
        }
    }
}
