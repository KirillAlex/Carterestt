using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Data;
<<<<<<< HEAD
using NUnit;
=======
>>>>>>> d198e5d06df4f0db1032d3302f5e1e095185431e

namespace Carterestt.Controllers
{
    public class BrandsController : Controller
<<<<<<< HEAD
    { //
      /// <summary>
      /// Този клас управлява (създава , редактира и изтрива) марки 
      /// </summary>
      /// <remarks>
      ///     Автор: Кирилл Алексеев
      /// </remarks>
=======
    {
>>>>>>> d198e5d06df4f0db1032d3302f5e1e095185431e
        private CarContext db = new CarContext();

        // GET: Brands
        public ActionResult Index()
        {
            return View(db.Brands.ToList());
        }

        // GET: Brands/Details/5
<<<<<<< HEAD
        
=======
>>>>>>> d198e5d06df4f0db1032d3302f5e1e095185431e
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Brand brand = db.Brands.Find(id);
            if (brand == null)
            {
                return HttpNotFound();
            }
            return View(brand);
        }

<<<<<<< HEAD
        [Authorize]
=======
>>>>>>> d198e5d06df4f0db1032d3302f5e1e095185431e
        // GET: Brands/Create
        public ActionResult Create()
        {
            return View();
        }

<<<<<<< HEAD
        // POST: Brands/Create 
        
        [Authorize]
=======
        // POST: Brands/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
>>>>>>> d198e5d06df4f0db1032d3302f5e1e095185431e
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Decription")] Brand brand)
        {
            if (ModelState.IsValid)
            {
                db.Brands.Add(brand);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(brand);
        }

        // GET: Brands/Edit/5
<<<<<<< HEAD
        [Authorize]
=======
>>>>>>> d198e5d06df4f0db1032d3302f5e1e095185431e
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Brand brand = db.Brands.Find(id);
            if (brand == null)
            {
                return HttpNotFound();
            }
            return View(brand);
        }

        // POST: Brands/Edit/5
<<<<<<< HEAD
        
        [Authorize]
=======
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
>>>>>>> d198e5d06df4f0db1032d3302f5e1e095185431e
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Decription")] Brand brand)
        {
            if (ModelState.IsValid)
            {
                db.Entry(brand).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(brand);
        }

        // GET: Brands/Delete/5
<<<<<<< HEAD
        [Authorize]
=======
>>>>>>> d198e5d06df4f0db1032d3302f5e1e095185431e
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Brand brand = db.Brands.Find(id);
            if (brand == null)
            {
                return HttpNotFound();
            }
            return View(brand);
        }

        // POST: Brands/Delete/5
<<<<<<< HEAD
        [Authorize]
=======
>>>>>>> d198e5d06df4f0db1032d3302f5e1e095185431e
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Brand brand = db.Brands.Find(id);
            db.Brands.Remove(brand);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
<<<<<<< HEAD


=======
>>>>>>> d198e5d06df4f0db1032d3302f5e1e095185431e
    }
}
