using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Runtime.InteropServices.Expando;
using MVCMovieManager.Models;
using PagedList;
using PagedList.Mvc;
using MVCMovieManager.ViewModels;
using System.Dynamic;

namespace MVCMovieManager.Controllers
{
    public class MovieController : Controller
    {
        private MovieManagerEntities db = new MovieManagerEntities();

        
        public ActionResult Index(FormCollection data)
        {

          

           

            List<MovieViewModel> moviesViewModel;
            moviesViewModel = (from movie in db.Movies
                               select new MovieViewModel()
                               {
                                   MovieId = movie.MovieId,
                                   Title = movie.Title,
                                   Rating = movie.Rating,
                                   Year = movie.Year,
                                   Producer = movie.Producer,
                                   Description = movie.Description,
                                   Seasons = movie.Seasons,
                                   Status = movie.Status,
                                   GenreType = movie.Genre.GenreType,
                                   Watched = movie.Watcheds.Any(),
                                   WatchList = movie.WatchLists.Any()

                               }).ToList();



            ////var GenreQry = from d in db.Movies
            ////                orderby d.Genre.GenreType
            ////               select d.Genre.GenreType;

            ////GenreLst.AddRange(GenreQry.Distinct());

            ////ViewBag.Genre = new SelectList(GenreLst);

            ////ViewBag.CurrentFilter = searchString;

            //if (postMainPageModel.FilterModel!= null && !string.IsNullOrEmpty(postMainPageModel.FilterModel.SearchString))
            //{
            //    moviesViewModel = moviesViewModel.Where(s => s.Title.Contains(postMainPageModel.FilterModel.SearchString)).ToList();
            //}

            //if (postMainPageModel.FilterModel != null && postMainPageModel.FilterModel.SelectedGenre != null)
            //{
            //    moviesViewModel = moviesViewModel.Where(x => x.GenreType == postMainPageModel.FilterModel.SelectedGenre.GenreType || postMainPageModel.FilterModel.SelectedGenre.GenreType == "All").ToList();
            //}

            MainPageViewModel getMainPageModel = new MainPageViewModel();

            getMainPageModel.FilterModel = new FilterViewModel();
            getMainPageModel.FilterModel.GenreTypes = db.Genres.Select(gen => new SelectListItem() { Value = gen.GenreID.ToString(), Text = gen.GenreType }).ToList();

            getMainPageModel.FilterModel.GenreTypes.Add(new SelectListItem() { Value = "0", Text = "All" });

            getMainPageModel.FilterModel.SearchString = string.Empty;

            getMainPageModel.MovieModel = moviesViewModel.ToList().ToPagedList(1, 3);
            return View(getMainPageModel);
        }

        //[HttpPost]
       // public ActionResult AddtoWatchList(FormCollection formcollection)
        //{
        //    Boolean watchListCheckBoxValue = bool.Parse(formcollection["WatchListCheckbox"]);

        //    List<WatchListViewModel> watchListData;
        //    WatchListViewModel wldata = new WatchListViewModel();
        //    WatchList watchListMovie=new WatchList();

        //    var movies = (from wl in db.WatchLists
        //                  select new WatchListViewModel
        //                  {
        //                      WatchListId = wl.WatchListId,
        //                      MovieId = wl.MovieId,
        //                      Title = wl.Title,
        //                      Rating = wl.Rating,
        //                      Year = wl.Year,
        //                      Producer = wl.Producer,
        //                      Description = wl.Description,
        //                      Seasons = wl.Seasons,
        //                      Status = wl.Status,
        //                      Genre = wl.Genre.GenreType
        //                  }).ToList();





        //    watchListData = new List<WatchListViewModel>(movies);


        //    if(watchListCheckBoxValue)
        //    {
        //        watchListData.Add(wldata);

        //        foreach (var watchlist in watchListData)
        //        {
        //            watchListMovie.MovieId = watchlist.MovieId;

        //            db.WatchLists.Add(watchListMovie);
        //            db.SaveChanges();
        //        }



        //    }

        //    else
        //    {
        //        watchListData.Remove(wldata);
        //    }



        //    //var movies = (from m in db.Movies
        //    //              select m).ToList();


        //    //var movies = (from wl in db.Movies
        //    //              select new WatchListViewModel
        //    //              {
        //    //                  //WatchListId = wl.WatchListId,
        //    //                  MovieId = wl.MovieId,
        //    //                  Title = wl.Title,
        //    //                  Rating = wl.Rating,
        //    //                  Year = wl.Year,
        //    //                  Producer = wl.Producer,
        //    //                  Description = wl.Description,
        //    //                  Seasons = wl.Seasons,
        //    //                  Status = wl.Status,
        //    //                  Genre = wl.Genre.GenreType
        //    //              }).ToList();



        //    //watchListData.AddRange(movies);

        //    //if (watchListCheckBoxValue == true)
        //    //{
        //    //    foreach (var wlist in movies )
        //    //    {
        //    //        var  watchListMovie = new WatchList();

        //    //        watchListMovie.MovieId = wlist.MovieId;
        //    //      

        //    //        if (watchListMovie.WatchListId == 0)
        //    //        {
        //    //            var uniqueMovie = db.Movies.FirstOrDefault(a => a.MovieId == watchListMovie.MovieId);

        //    //            if (uniqueMovie == null)
        //    //            {
        //    //                db.Entry(watchListMovie).State = System.Data.Entity.EntityState.Added;
        //    //                db.WatchLists.Add(watchListMovie);
        //    //            }
        //    //        }

        //    //        else
        //    //        {
        //    //            db.WatchLists.Attach(watchListMovie);
        //    //            db.Entry(watchListMovie).State = System.Data.Entity.EntityState.Modified;
        //    //        }

        //    //        db.SaveChanges();
        //    //    }



        //    //}

        //    return View();
        //}



        [HttpPost]
        public ActionResult AddtoWatchList(bool value)
        {
            
            List<WatchList> watchListMovie = new List<WatchList>();
            List<Movie> movieList = new List<Movie>();
            WatchList watch = new WatchList();
           

            var movies = from m in db.Movies
                         select m;

            movieList.AddRange(movies);

              if(value)
            {
                   
                    db.WatchLists.Add(watch);
                    db.SaveChanges();
               

            }

            return View();
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

        public ActionResult DetailsViewModel(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }


            List<MovieViewModel> moviesViewModel;
            moviesViewModel = (from movie in db.Movies
                                   select new MovieViewModel()
                                   {
                                       MovieId = movie.MovieId,
                                       Title = movie.Title,
                                       Rating = movie.Rating,
                                       Year = movie.Year,
                                       Producer = movie.Producer,
                                       Description = movie.Description,
                                       Seasons = movie.Seasons,
                                       Status = movie.Status,
                                       GenreType = movie.Genre.GenreType,
                                       Watched = movie.Watcheds.Any(),
                                       WatchList = movie.WatchLists.Any()

                                   }).ToList();
            if (moviesViewModel == null)
            {
                return HttpNotFound();
            }
            return View(moviesViewModel);
        }
        // GET: Movies/Create
        public ActionResult Create()
        {
            ViewBag.GenreId = new SelectList(db.Genres, "GenreID", "GenreType");
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MovieId,Title,Rating,Year,Producer,Description,Seasons,Status,GenreId")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Movies.Add(movie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GenreId = new SelectList(db.Genres, "GenreID", "GenreType", movie.GenreId);
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
            ViewBag.GenreId = new SelectList(db.Genres, "GenreID", "GenreType", movie.GenreId);
            return View(movie);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MovieId,Title,Rating,Year,Producer,Description,Seasons,Status,GenreId")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GenreId = new SelectList(db.Genres, "GenreID", "GenreType", movie.GenreId);
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
