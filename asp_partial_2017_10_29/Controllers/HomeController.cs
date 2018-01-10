using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asp_partial_2017_10_29.Controllers
{

    public class HomeController : Controller
    {
        public ActionResult Show()
        {
            //SelectList prods = new SelectList(db.Products, "Id", "Name");
            //ViewBag.Prods = prods;

            return View();
        }

        [Route("")]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
           
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // [Route(Name = "test")]
        //[HttpGet("",""]
        public string Test(string param1,string param2)
        {
            return param1 + param2;
        }
    }
}