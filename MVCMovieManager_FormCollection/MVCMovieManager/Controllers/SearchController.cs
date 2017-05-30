using MVCMovieManager.Models;
using MVCMovieManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace MVCMovieManager.Controllers
{
    public class SearchController : Controller
    {
        private MovieManagerEntities db = new MovieManagerEntities();






        //public ActionResult Search(string SearchString, string Genre)
        //{

        //    List<MovieViewModel> moviesViewModel;
        //    moviesViewModel = (from movie in db.Movies
        //                       select new MovieViewModel()
        //                       {
        //                           MovieId = movie.MovieId,
        //                           Title = movie.Title,
        //                           Rating = movie.Rating,
        //                           Year = movie.Year,
        //                           Producer = movie.Producer,
        //                           Description = movie.Description,
        //                           Seasons = movie.Seasons,
        //                           Status = movie.Status,
        //                           GenreType = movie.Genre.GenreType,
        //                           Watched = movie.Watcheds.Any(),
        //                           WatchList = movie.WatchLists.Any()

        //                       }).ToList();

        //    var movies = db.Movies.ToList();
        //    MainViewModel getMainPageModel = new MainViewModel();

        //    var filter = new FilterViewModel();

        //    filter.GenreTypes = db.Genres.Select(gen => new SelectListItem() { Value = gen.GenreID.ToString(), Text = gen.GenreType }).ToList();
        //    filter.GenreTypes.Add(new SelectListItem() { Value = "0", Text = "All" });
        //    filter.SearchString = string.Empty;


        //    var GenreQry = from d in db.Genres
        //                   orderby d.GenreType
        //                   select d.GenreType;






        //    if (!String.IsNullOrEmpty(searchString))
        //    {

        //        movies = movies.Where(s => s.Title.Contains(searchString)).ToList();
        //    }

        //    if (!string.IsNullOrEmpty(Genre))
        //    {
        //        movies = movies.Where(x => x.Genre.GenreType == Genre).ToList();
        //    }


        //    return PartialView("_Search");
        //}

        [HttpGet]
        public PartialViewResult Search_Partial()
        {
         

            FilterViewModel filterViewModel = new FilterViewModel();

            filterViewModel.GenreTypes = db.Genres.Select(gen => new SelectListItem() { Value = gen.GenreID.ToString(), Text = gen.GenreType }).ToList();

            filterViewModel.GenreTypes.Add(new SelectListItem() { Value = "-1", Text ="All" });


            filterViewModel.SearchString = Session["selectedTitle"] == null ? "" : Session["selectedTitle"].ToString();
            filterViewModel.SelectedGenre = Session["selectedGenre"] == null ? -1 : int.Parse(Session["selectedGenre"].ToString());

           
        

            return PartialView("Search_Partial", filterViewModel);
        }


        [HttpPost]
        public ActionResult Search_Partial(FilterViewModel filter)
        {

            Session["selectedGenre"] = filter.SelectedGenre;
            Session["selectedTitle"] = filter.SearchString;


           return RedirectToAction ("Index", "Movie", new {  searchString = filter.SearchString ,  genreId=filter.SelectedGenre});

        }


    }
}
