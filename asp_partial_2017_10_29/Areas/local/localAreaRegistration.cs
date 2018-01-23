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
                name: "local_default_to_testRoute",
                url: "local-test/local-{str}",
                defaults: new { controller = "Products", action = "testRoute" },
                namespaces: new string[] { "asp_partial_2017_10_29.Areas.local.Controllers" }
            );

            context.MapRoute(
                  name: "localindexpath",
                  url: "localarea-{controller}/{action}/{id}",
                  defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                  namespaces: new string[] { "asp_partial_2017_10_29.Areas.local.Controllers" }

      );
        }
    }
}