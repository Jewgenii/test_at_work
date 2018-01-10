using System.Web;
using System.Web.Mvc;

namespace asp_partial_2017_10_29
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
