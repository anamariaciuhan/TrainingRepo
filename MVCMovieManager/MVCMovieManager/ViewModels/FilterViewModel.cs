using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCMovieManager.Models;
using System.Web.Mvc;

namespace MVCMovieManager.ViewModels
{
    public class FilterViewModel
    {
        public List<SelectListItem> GenreTypes { get; internal set; }

        public Genre SelectedGenre { get; set; }

        public string SearchString { get; internal set; }
    }
}