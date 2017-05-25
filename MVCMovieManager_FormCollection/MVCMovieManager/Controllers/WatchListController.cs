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
    public class WatchListController : Controller
    {
        private MovieManagerEntities db = new MovieManagerEntities();


        // GET: WatchList
        public ActionResult Index()
        {
            var watchLists = db.WatchList.Include(w => w.Movie);
            return View(watchLists.ToList());
        }

        // GET: WatchList/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WatchList watchList = db.WatchList.Find(id);
            if (watchList == null)
            {
                return HttpNotFound();
            }
            return View(watchList);
        }

        // GET: WatchList/Create
        public ActionResult Create()
        {
            ViewBag.MovieId = new SelectList(db.Movies, "MovieId", "Title");
            return View();
        }

        // POST: WatchList/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WatchListId,MovieId")] WatchList watchList)
        {
            if (ModelState.IsValid)
            {
                db.WatchList.Add(watchList);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MovieId = new SelectList(db.Movies, "MovieId", "Title", watchList.MovieId);
            return View(watchList);
        }

        // GET: WatchList/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WatchList watchList = db.WatchList.Find(id);
            if (watchList == null)
            {
                return HttpNotFound();
            }
            ViewBag.MovieId = new SelectList(db.Movies, "MovieId", "Title", watchList.MovieId);
            return View(watchList);
        }

        // POST: WatchList/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WatchListId,MovieId")] WatchList watchList)
        {
            if (ModelState.IsValid)
            {
                db.Entry(watchList).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MovieId = new SelectList(db.Movies, "MovieId", "Title", watchList.MovieId);
            return View(watchList);
        }

        // GET: WatchList/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WatchList watchList = db.WatchList.Find(id);
            if (watchList == null)
            {
                return HttpNotFound();
            }
            return View(watchList);
        }

        // POST: WatchList/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WatchList watchList = db.WatchList.Find(id);
            db.WatchList.Remove(watchList);
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
