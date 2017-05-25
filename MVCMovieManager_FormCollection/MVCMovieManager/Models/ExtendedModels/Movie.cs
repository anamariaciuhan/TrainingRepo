using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCMovieManager.Models
{
    public partial class Movie
    {

        public bool WatchList
        {
            get { return this.WatchLists.Any(); } private set { }
        }
    }
}