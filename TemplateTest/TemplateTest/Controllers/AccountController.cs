using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TemplateTest.Controllers
{
    public class AccountController : Controller
    {
        public AccountController()
        {
        }
                
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

    }
}
