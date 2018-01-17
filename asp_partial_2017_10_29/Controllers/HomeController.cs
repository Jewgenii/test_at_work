using asp_partial_2017_10_29.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace asp_partial_2017_10_29.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        ApplicationDbContext con = new ApplicationDbContext();

        ApplicationUserManager manager;

        public ActionResult Show()
        {
            //SelectList prods = new SelectList(db.Products, "Id", "Name");
            //ViewBag.Prods = prods;

            ApplicationUser user = con.Users.FirstOrDefault();

            return View();
        }

       // [AllowAnonymous]
        [Route("")]
        public ActionResult Index()
        {
             
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            //User.Identity.Name
            

            var userID = User.Identity.GetUserId();

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

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                con.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}