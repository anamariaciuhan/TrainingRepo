using MVCMovieManager.Models;
using System;
using System.Collections.Generic;

namespace MVCMovieManager.ViewModels
{
    public class WatchedViewModel
    {


        public WatchedViewModel()
        { }
        public int MovieId { get; set; }
        public string Title { get; set; }

        public double? Rating { get; set; }

        public string Producer { get; set; }

        public Nullable<bool> Favourite { get; set; }


        public DateTime Year { get; set; }
        public string Description { get; set; }



        public int? Seasons { get; set; }
        public string Status { get; set; }


        public string Genre { get; set; }
        public int WatchedId { get; internal set; }


    }
}