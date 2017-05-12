using System;
using System.Collections.Specialized;

namespace MovieManager
{
    internal class MovieGridViewModel
    {
        public MovieGridViewModel()
        { }

        public int MovieId { get; set; }
        public string Title { get; set; }

        public double? Rating { get; set; }

        public string Producer { get; set; }

       // public string GenreType { get; set; }

        //public string Test { get; set; }

        public DateTime? Year { get; set; }
        public string Description { get;  set; }
        
          
        
        public int? Seasons { get;  set; }
        public string Status { get;  set; }
        
        public bool Watched { get; set; }
        public bool WatchList { get; set; }

    }
    
}