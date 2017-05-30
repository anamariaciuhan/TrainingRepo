using MVCMovieManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace MVCMovieManager.ViewModels
{
    public class FilterViewModel
    {
      
       

        public int SelectedGenre { get; set; }

        public string SearchString { get; set; }

        public List<SelectListItem> GenreTypes { get; set; }


    }
}