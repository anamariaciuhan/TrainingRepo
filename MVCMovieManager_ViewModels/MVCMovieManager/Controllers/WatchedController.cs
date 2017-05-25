using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCMovieManager.Models;

namespace MVCMovieManager.Controllers
{
    public class WatchedController : Controller
    {
        private MovieManagerEntities db = new MovieManagerEntities();

        // GET: Watched
        public ActionResult Index()
        {
            var watcheds = db.Watcheds.Include(w => w.Movie);
            return View(watcheds.ToList());
        }

        // GET: Watched/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Watched watched = db.Watcheds.Find(id);
            if (watched == null)
            {
                return HttpNotFound();
            }
            return View(watched);
        }

        // GET: Watched/Create
        public ActionResult Create()
        {
            ViewBag.MovieId = new SelectList(db.Movies, "MovieId", "Title");
            return View();
        }

        // POST: Watched/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WatchedId,MovieId,Favourite")] Watched watched)
        {
            if (ModelState.IsValid)
            {
                db.Watcheds.Add(watched);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MovieId = new SelectList(db.Movies, "MovieId", "Title", watched.MovieId);
            return View(watched);
        }

        // GET: Watched/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Watched watched = db.Watcheds.Find(id);
            if (watched == null)
            {
                return HttpNotFound();
            }
            ViewBag.MovieId = new SelectList(db.Movies, "MovieId", "Title", watched.MovieId);
            return View(watched);
        }

        // POST: Watched/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WatchedId,MovieId,Favourite")] Watched watched)
        {
            if (ModelState.IsValid)
            {
                db.Entry(watched).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MovieId = new SelectList(db.Movies, "MovieId", "Title", watched.MovieId);
            return View(watched);
        }

        // GET: Watched/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Watched watched = db.Watcheds.Find(id);
            if (watched == null)
            {
                return HttpNotFound();
            }
            return View(watched);
        }

        // POST: Watched/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Watched watched = db.Watcheds.Find(id);
            db.Watcheds.Remove(watched);
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
    }
}
