using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TemplateTest.Models;

namespace TemplateTest.Controllers
{
    public class AccountController : Controller
    {
        public AccountController()
        {
        }
        
        public ActionResult Login()
        {
            var model = new LoginModel();
            return View(model);
        }

        public ActionResult Register()
        {
            return View();
        }

    }
}
