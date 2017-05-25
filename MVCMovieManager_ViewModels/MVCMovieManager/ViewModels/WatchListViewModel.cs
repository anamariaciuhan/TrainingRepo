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

        public string Description { get; internal set; }
        public string Genre { get; internal set; }
        public int MovieId { get; internal set; }
        public string Producer { get; internal set; }
        public double? Rating { get; internal set; }
        public int? Seasons { get; internal set; }
        public string Status { get; internal set; }
        public string Title { get; internal set; }
        public int WatchListId { get; internal set; }
        public DateTime Year { get; internal set; }
    }
}