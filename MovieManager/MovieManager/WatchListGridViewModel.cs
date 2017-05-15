using System;

namespace MovieManager
{
    internal class WatchListGridViewModel
    {
        private MovieGridViewModel selectedMovie;

        public int WatchListId { get; set; }

        public int MovieId { get; set; }

        public string Title { get; set; }

        public double? Rating { get; set; }

        public string Producer { get; set; }

       // public string Genre { get; set; }

        public DateTime? Year { get; set; }

        public string Description { get; set; }
      
            
        public int? Seasons { get; set; }
        public string Status { get; set; }



        public void SetProp(MovieGridViewModel selectedMovie)
        {
            Title = selectedMovie.Title;
            MovieId = selectedMovie.MovieId;
            Rating = selectedMovie.Rating;
            Producer = selectedMovie.Producer;
            //Genre = selectedMovie.Genre;
            Year = selectedMovie.Year;
            Description = selectedMovie.Description;
            Seasons = selectedMovie.Seasons;
            Status = selectedMovie.Status;
        }

        public WatchListGridViewModel()
        {
            
        }

        public WatchListGridViewModel(MovieGridViewModel selectedMovie)
        {
            SetProp(selectedMovie);
        }
    }
}