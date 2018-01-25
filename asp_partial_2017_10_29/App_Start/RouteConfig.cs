using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace asp_partial_2017_10_29
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //routes.Add( new Route("", new StopRoutingHandler())
            //    );

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
            name: "test",
            url: "{param1}-{param2}",
            defaults: new { controller = "Home", action = "Test" },
             namespaces: new string[] { "asp_partial_2017_10_29.Controllers" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "asp_partial_2017_10_29.Controllers" }
            );

            routes.MapRoute(
                name: "lanc",
                url: "sprache-{language}:{country}",
                defaults: new { controller = "home", action = "lanc" },
                namespaces: new string[] { "asp_partial_2017_10_29.Controllers" }
                );

        }
    }
}
