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






        [HttpGet]
        public PartialViewResult Search_Partial(string viewName)
        {
            //reset filter in when viewName is different than previous in session

            if (Session["viewName"] != null && Session["viewName"].ToString() !=viewName)
            {
                Session["searchString"] = string.Empty ;
                Session["selectedGenre"] = -1;
            }

            Session["viewName"] = viewName;

            FilterViewModel filterViewModel = new FilterViewModel();

            filterViewModel.GenreTypes = db.Genres.Select(gen => new SelectListItem() { Value = gen.GenreID.ToString(), Text = gen.GenreType }).ToList();

            filterViewModel.GenreTypes.Add(new SelectListItem() { Value = "-1", Text = "All" });


            filterViewModel.SearchString = Session["searchString"] == null ? "" : Session["searchString"].ToString();
            filterViewModel.SelectedGenre = Session["selectedGenre"] == null ? -1 : int.Parse(Session["selectedGenre"].ToString());




            return PartialView("Search_Partial", filterViewModel);
        }


        


        [HttpPost]
        public ActionResult Search_Partial(FilterViewModel filter)
        {

            Session["selectedGenre"] = filter.SelectedGenre;
            Session["searchString"] = filter.SearchString;

            var viewNameToRedirect = Session["viewName"].ToString();

           return RedirectToAction ("Index", viewNameToRedirect, new {  searchString = filter.SearchString ,  genreId=filter.SelectedGenre});

        }


    }
}
