using System;

namespace MVCMovieManager.ViewModels
{
      public class MovieViewModel
    {
        public MovieViewModel()
        { }


        public string Description { get; internal set; }
        public string GenreType { get; internal set; }
        public int MovieId { get; internal set; }
        public string Producer { get; internal set; }
        public double? Rating { get; internal set; }
        public int? Seasons { get; internal set; }
        public string Status { get; internal set; }
        public string Title { get; internal set; }
        public bool Watched { get; internal set; }
        public bool WatchList { get; internal set; }
        public DateTime Year { get; internal set; }
    }
}