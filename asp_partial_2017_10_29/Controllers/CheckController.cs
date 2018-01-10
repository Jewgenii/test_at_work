using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asp_partial_2017_10_29.Controllers
{

    public class CheckController : Controller
    {
        // GET: Check
        [HttpGet]
        [AllowAnonymous]
        public JsonResult StringInfo(string Info)
        {
           // ModelState.AddModelError
            return Json(Info!="me", behavior: JsonRequestBehavior.AllowGet);
        }
    }
}