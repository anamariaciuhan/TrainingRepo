using System;

namespace MovieManager
{
    internal class WatchListGridViewModel
    {
        public int WatchListId { get; set; }

        public int MovieId { get; set; }

        public string Title { get; set; }

        public double? Rating { get; set; }

        public string Producer { get; set; }

        public string Genre { get; set; }

        public DateTime? Year { get; set; }

        public string Description { get; set; }
      
            
        public int? Seasons { get; set; }
        public string Status { get; set; }
        
        
    }
}