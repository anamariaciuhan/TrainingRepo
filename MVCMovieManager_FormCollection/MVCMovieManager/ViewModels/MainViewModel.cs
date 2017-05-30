using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCMovieManager.Models;

namespace MVCMovieManager.ViewModels
{
    public class MainViewModel
    {
       

        public FilterViewModel FilterModel { get; set; }
        public WatchedViewModel WatchedModel { get; set; }
        public IEnumerable<Watched> WatchedMoviesList { get; set ; }



    
        
        public IEnumerable<WatchList> WatchListMoviesList { get; set; }

        public IEnumerable<Movie> MovieList { get; set; }

        //public MovieViewModel MovieModel { get; set; }
     

        //public WatchListViewModel WatchlistModel { get; set; }

        //public IEnumerable<WatchedViewModel> WatchedModelList { get; set; }
        
      

    }







}