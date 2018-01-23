using System.Web.Mvc;

namespace asp_partial_2017_10_29.Areas.local
{
    public class localAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "local";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                name: "local_default",
                url: "test/local-{str}",
                defaults: new { controller = "Products", action = "testRoute" },
                namespaces: new string[] { "asp_partial_2017_10_29.Areas.local.Controllers" }
            );

            context.MapRoute(
                  name: "Default_path_local",
                  url: "test/{controller}/{action}/{id}",
                  defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                  namespaces: new string[] { "asp_partial_2017_10_29.Areas.local.Controllers" }
      );
        }
    }
}