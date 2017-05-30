using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCMovieManager.ViewModels
{
    public class WatchListViewModel
    {
        public WatchListViewModel()
        { }

        public int MovieId { get; set; }
        public string Title { get; set; }

        public double? Rating { get; set; }

        public string Producer { get; set; }




        public DateTime Year { get; set; }
        public string Description { get; set; }



        public int? Seasons { get; set; }
        public string Status { get; set; }


        public string Genre { get;  set; }
        public int WatchListId { get; internal set; }
    }





}