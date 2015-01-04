using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TemplateTest.Models;

namespace TemplateTest.Controllers
{
    public class ArticleController : Controller
    {
        //
        // GET: /Article/
        public ContentResult GetByUrl(string seoUrl)
        {
            return new ContentResult() { Content = "#" + seoUrl + "#" };
        }

        public ActionResult Recent()
        {
            var model = new RecentDataModel();
            return View(model);
        }
    }
}
