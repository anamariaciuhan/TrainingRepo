using System;

namespace MovieManager
{
    internal class WatchedGridViewModel
    {

        public int WatchedId { get; set; }

        public int MovieId { get; internal set; }

        public string Title { get; internal set; }

        public double? Rating { get; internal set; }

        public string Producer { get; internal set; }

        public string Genre { get; internal set; }

        public DateTime? Year { get; internal set; }

        public string Description { get; internal set; }

        internal int? Seasons;

        public string Status { get; internal set; }


        


    }
}