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
        public ActionResult Recent()
        {
            var model = new RecentDataModel();
            return View(model);
        }
    }
}
