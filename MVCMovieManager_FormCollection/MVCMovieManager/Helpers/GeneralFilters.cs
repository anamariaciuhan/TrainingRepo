using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCMovieManager.Helpers
{
    public class GeneralFilters<T> 
    {
        public static IEnumerable<T> FilterGeneral<T>(IEnumerable<T> listToBeFiltred,string searchString, int? genreId) where T : class
        {
          
            if (!String.IsNullOrEmpty(searchString))
            {

                listToBeFiltred = listToBeFiltred.Where(s => s.GetType().GetProperty("Title").GetValue(s).ToString().Contains(searchString)).ToList();
            }

            if (genreId != null && genreId != -1)
            {
                listToBeFiltred = listToBeFiltred.Where(x =>Convert.ToInt32( x.GetType().GetProperty("GenreID").GetValue(x).ToString()) == genreId).ToList();
            }


            return listToBeFiltred;

        }
    }
}