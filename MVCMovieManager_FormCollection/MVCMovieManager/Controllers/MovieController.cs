using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCMovieManager.Models;
using PagedList;
using PagedList.Mvc;
using MVCMovieManager.ViewModels;
using MVCMovieManager.Helpers;

namespace MVCMovieManager.Controllers
{
    public class MovieController : Controller
    {
        private MovieManagerEntities db = new MovieManagerEntities();
        

        // GET: Movies
        public ActionResult Index(string searchString, int? genreId, int? page )
        {
            var movies = db.Movies.Include("WatchLists").Include("Watcheds").ToList();

            var filtredList = GeneralFilters<Movie>.FilterGeneral(movies, searchString,genreId);

            return View(filtredList.ToList().ToPagedList(page ?? 1,3));
        }


        [HttpPost]
        public ActionResult FormCollection(FormCollection formcoll)
        {
            
            foreach (var key in formcoll.AllKeys)
            {

                var movieId = Convert.ToInt32(key.Split(new string[] { "_" }, StringSplitOptions.RemoveEmptyEntries)[1]);

                if (key.Contains("watchlist_"))
                HandleWatchList(formcoll, key, movieId);

                else if(key.Contains("watched_"))

                HandleWatched(formcoll, key, movieId);

            }



            db.SaveChanges();

         

            return RedirectToAction("Index");

        }

        private void HandleWatched(FormCollection formcoll, string key, int movieId)
        {
            bool watchedValue = false;


            if (formcoll[key].Contains("true,false"))
            {
                watchedValue = true;

            }

            var watchedExists = db.Watched.FirstOrDefault(x => x.MovieId == movieId);


            if (watchedValue&& watchedExists == null)
            {
                db.Watched.Add(new Watched { MovieId = movieId });

            }

            else if (!watchedValue && watchedExists != null)
            {
                db.Watched.Remove(watchedExists);
            }

        }

        private void HandleWatchList(FormCollection formcoll, string key, int movieId)
        {
            bool watchlistValue = false;


            if (formcoll[key].Contains("true,false"))
            {
                watchlistValue = true;

            }

            var movieExists = db.WatchList.FirstOrDefault(x => x.MovieId == movieId);


            if (watchlistValue && movieExists == null)
            {
                db.WatchList.Add(new WatchList { MovieId = movieId });

            }

            else if (!watchlistValue && movieExists != null)
            {
                db.WatchList.Remove(movieExists);
            }
        }



        // GET: Movies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // GET: Movies/Create
        public ActionResult Create()
        {
            ViewBag.GenreID = new SelectList(db.Genres, "GenreID", "GenreType");
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MovieId,Title,Rating,Year,Producer,Description,Seasons,Status,GenreID")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Movies.Add(movie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GenreID = new SelectList(db.Genres, "GenreID", "GenreType", movie.GenreID);
            return View(movie);
        }

        // GET: Movies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            ViewBag.GenreID = new SelectList(db.Genres, "GenreID", "GenreType", movie.GenreID);
            return View(movie);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MovieId,Title,Rating,Year,Producer,Description,Seasons,Status,GenreID")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GenreID = new SelectList(db.Genres, "GenreID", "GenreType", movie.GenreID);
            return View(movie);
        }

        // GET: Movies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Movie movie = db.Movies.Find(id);
            db.Movies.Remove(movie);
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
