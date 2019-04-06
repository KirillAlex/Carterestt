using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
<<<<<<< HEAD
using Carterestt.Models;
=======
>>>>>>> d198e5d06df4f0db1032d3302f5e1e095185431e
using Data;
using Microsoft.AspNet.Identity;

namespace Carterestt.Controllers
<<<<<<< HEAD
/// <summary>
/// Този клас създава публикации
/// </summary>
/// <remarks>
///     Автор: Бюлент Казали
/// </remarks>
{ 
=======
{
>>>>>>> d198e5d06df4f0db1032d3302f5e1e095185431e
    public class PostsController : Controller
    {
        private CarContext db = new CarContext();

        // GET: Posts
        public ActionResult Index()
        {
            return View(db.Posts.ToList());
        }

        // GET: Posts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.Posts.Find(id);
<<<<<<< HEAD
            ApplicationDbContext applicationDbContext = new ApplicationDbContext();
            if (post.UserId != null)
            {
                var user = applicationDbContext.Users.Find(post.UserId);
                post.UserId = user.UserName;
            }
            else
            {
                post.UserId = null;
            }

=======
>>>>>>> d198e5d06df4f0db1032d3302f5e1e095185431e
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        // GET: Posts/Create
<<<<<<< HEAD
        [Authorize]
        public ActionResult Create()
        {
            ViewBag.Brands = db.Brands.ToList();
            return View(
            );
        }

        
=======
        public ActionResult Create()
        {
            return View();
        }

        // POST: Posts/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
>>>>>>> d198e5d06df4f0db1032d3302f5e1e095185431e
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Decription,FileName,UserId")] Post post)
        {
            if (ModelState.IsValid)
            {
                post.UserId = User.Identity.GetUserId();
<<<<<<< HEAD
                var brandId = Request.Form["brandId"];
                post.BrandPosts = new List<BrandPost>() {
                    new BrandPost() { BrandId = int.Parse(brandId), Post = post }
                };
=======
>>>>>>> d198e5d06df4f0db1032d3302f5e1e095185431e
                db.Posts.Add(post);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(post);
        }

<<<<<<< HEAD
        [Authorize]
=======
>>>>>>> d198e5d06df4f0db1032d3302f5e1e095185431e
        // GET: Posts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

<<<<<<< HEAD
     
        [Authorize]
=======
        // POST: Posts/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
>>>>>>> d198e5d06df4f0db1032d3302f5e1e095185431e
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Decription,FileName,UserId")] Post post)
        {
            if (ModelState.IsValid)
            {
                post.UserId = User.Identity.GetUserId();
                db.Entry(post).State = EntityState.Modified;

                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(post);
        }

<<<<<<< HEAD
        
=======
        // GET: Posts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        // POST: Posts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Post post = db.Posts.Find(id);
            db.Posts.Remove(post);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
>>>>>>> d198e5d06df4f0db1032d3302f5e1e095185431e

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
