using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using asp_partial_2017_10_29.Models;

namespace asp_partial_2017_10_29.Controllers
{
    //[Authorize]
    
    [RoutePrefix("Products")]
    [Route("{action=Index}/{id?}")]
    public class ProductsController : Controller
    {
        private DBContext db = new DBContext();
        
        [AllowAnonymous]
        // GET: Products
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Products/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Name,Info,Price,Picture")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(product);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Name,Info,Price,Picture")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // for jquery validation plugin
        public JsonResult AutoComplete([Bind(Include ="term")] string term)
        {
            var coll = (new string[] { "hello", "hi", "host" })
                                                                .Where(x => x.Contains(term))
                                                                .Select(x => new { value = x, label = "labled " + x })
                                                                .ToArray();
            return Json(coll, JsonRequestBehavior.AllowGet);
        }

        public JsonResult CollectionTestValuesJson(string q)
        {
            var set = new string[] { "aaa", "bbb", "ccc" }.Where(x => x.Contains(q)).ToArray();
            return Json(set,behavior:JsonRequestBehavior.AllowGet);
        }
        
        public ActionResult AutoCompleteNoJson(string id)
        {
            return PartialView(model:id);
        }
        //test routing
        //[Route("testroute/{str:int}")]
        public string testRoute(int str)
        {
            return str.ToString();
        }

        [HttpGet]
        [Route("{Pagination}/{currentPage/itemsToDisplay}")]
        public ActionResult Pagination(int? currentPage, int? itemsToDisplay = 5)
        {
            int _itemsToDisplay = 5;

            if (itemsToDisplay.Value <= 100)
                _itemsToDisplay = itemsToDisplay.Value;

            int _currentPage = 1;

            if (currentPage.HasValue && currentPage.Value > 1)
                _currentPage = currentPage.Value;

                ViewBag.currentPage = _currentPage;
                ViewBag.itemsToDisplay = _itemsToDisplay;

                IEnumerable<Product> prods = db.Products
                                                    .OrderBy(x => x.Name)
                                                    .Skip(_itemsToDisplay * (_currentPage - 1))
                                                    .Take(_itemsToDisplay)
                                                    .ToArray();
            int _last = prods.Count();
            if (_last == 0)
                return HttpNotFound();

            var el = db.Products.OrderBy(x => x.Name)
                                .Skip(_itemsToDisplay * _currentPage)
                                .FirstOrDefault();
            if (el != null)
                ViewBag.pagesleft = 1;
            else
                ViewBag.pagesleft = 0;


            return View(model: prods);
        }



        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
