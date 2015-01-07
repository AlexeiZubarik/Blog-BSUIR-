using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TemplateTest.Models;

namespace TemplateTest.Controllers
{
    public class PostsController : Controller
    {
        public ActionResult IndexPostItem()
        {
            var model = new Collection<PostItemViewModel>();
            model.Add(new PostItemViewModel("Title ME", "Bar", DateTime.Now.AddDays(-1), 5));
            return View(model);
        }

    }
}
