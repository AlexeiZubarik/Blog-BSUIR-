using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TemplateTest
{
    public class RouteConfig
    {
        private static readonly string[] Namespaces = new[] { "Routes.Controllers" };

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Post", "post-{title}", new { controller = "Home", action = "Index" });

            //routes.MapRoute(
            //   name: "article",
            //   url: "article-{seoUrl}",
            //   defaults: new { controller = "Article", action = "GetByUrl", seoUrl = string.Empty }
            //);

            routes.MapRoute("Default", "{controller}/{action}/{id}",
                new { controller = "home", action = "index", id = UrlParameter.Optional }
            );
        }
    }
}