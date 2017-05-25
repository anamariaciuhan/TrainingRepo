using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCMovieManager.ViewModels
{
    public class MainPageViewModel
    {
        public FilterViewModel FilterModel { get; set; }
        public IPagedList<MovieViewModel> MovieModel{ get; set; }



    }
}