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
                "local_default",
                "Prods/{str}",
                new { controller = "products", action = "testRoute"}
            );
        }
    }
}