using System.Web.Mvc;

namespace asp_partial_2017_10_29.Areas.tmp
{
    public class tmpAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "tmp";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "tmp_default",
                "tmp/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}