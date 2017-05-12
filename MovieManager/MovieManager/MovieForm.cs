using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress;
using DevExpress.XtraGrid;
using DevExpress.XtraEditors.Repository;
using System.Data.Entity;

namespace MovieManager
{
    public partial class MovieForm : Form
    {
        private BindingList<MovieGridViewModel> Movielist;

        private BindingList<WatchedGridViewModel> WatchedMovieList;

        private BindingList<WatchListGridViewModel> WatchList;

        public MovieForm()
        {
            InitializeComponent();

                       
           
        }

        private void MovieForm_Load(object sender, EventArgs e)
        {
            // load data from db
            LoadData();

            BindDataToGrids();

            gridView1.CellValueChanging += HandleWatchedChanged;
        }

        private void HandleWatchedChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
        }

        private void BindDataToGrids()
        {
            Movielist = new BindingList<MovieGridViewModel>(moviesGridViewModel);
            movieGrid.DataSource = Movielist;

            WatchedMovieList = new BindingList<WatchedGridViewModel>(watchedMoviesGridViewModel);
            gridWatched.DataSource = WatchedMovieList;

            WatchList = new BindingList<WatchListGridViewModel>(watchListGridViewModel);
            gridWatchList.DataSource = WatchList;
        }

        private void LoadData()
        {
            using (var dbContext = new MovieManagerEntities())
            {
                moviesGridViewModel = GetMovies(dbContext);

                watchedMoviesGridViewModel = GetWatched(dbContext);

                watchListGridViewModel = GetWatchList(dbContext);

                LoadGenreCombo(dbContext);
            }
        }

        private void LoadGenreCombo(MovieManagerEntities dbContext)
        {
            var populateGenre = from genre in dbContext.Genre
                                select genre.GenreType.ToString();

            foreach (var gen in populateGenre)
            {
                repositoryItemComboBox1.Items.Add(gen);

            }
        }

        private static List<WatchListGridViewModel> GetWatchList(MovieManagerEntities dbContext)
        {
            return (from watchlist in dbContext.WatchList
                    select new WatchListGridViewModel()
                    {

                        WatchListId = watchlist.WatchListId,
                        MovieId = watchlist.MovieId,
                        Title = watchlist.Movie.Title,
                        Rating = watchlist.Movie.Rating,
                        Year = watchlist.Movie.Year,
                        Producer = watchlist.Movie.Producer,
                        Description = watchlist.Movie.Description,
                        Seasons = watchlist.Movie.Seasons,
                        Status = watchlist.Movie.Status,
                        Genre = watchlist.Movie.Genre.GenreType

                    }).ToList();
        }

        private static List<WatchedGridViewModel> GetWatched(MovieManagerEntities dbContext)
        {
            return (from watched in dbContext.Watched
                    select new WatchedGridViewModel()
                    {
                        WatchedId = watched.WatchedId,
                        MovieId = watched.MovieId,
                        Title = watched.Movie.Title,
                        Rating = watched.Movie.Rating,
                        Year = watched.Movie.Year,
                        Producer = watched.Movie.Producer,
                        Description = watched.Movie.Description,
                        Seasons = watched.Movie.Seasons,
                        Status = watched.Movie.Status,
                        Genre = watched.Movie.Genre.GenreType

                    }).ToList();
        }

        private static List<MovieGridViewModel> GetMovies(MovieManagerEntities dbContext)
        {
            List<MovieGridViewModel> moviesGridViewModel;
            moviesGridViewModel = (from movie in dbContext.Movie
                                   select new MovieGridViewModel()
                                   {
                                       MovieId = movie.MovieId,
                                       Title = movie.Title,
                                       Rating = movie.Rating,
                                       Year = movie.Year,
                                       Producer = movie.Producer,
                                       Description = movie.Description,
                                       Seasons = movie.Seasons,
                                       Status = movie.Status,
                                       //GenreType=movie.Genre.GenreType,
                                       Watched = movie.Watched.Any(),
                                       WatchList = movie.WatchList.Any()

                                   }).ToList();
            return moviesGridViewModel;
        }




        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var newMovie = new MovieGridViewModel();

            Movielist.Add(newMovie);

          

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (var dbContext = new MovieManagerEntities())
            {
                 foreach (var movieViewModel in Movielist)
                  {
                     var movie = new Movie();

                      movie.Title = movieViewModel.Title;
                      movie.MovieId = movieViewModel.MovieId;
                      movie.Rating = movieViewModel.Rating;
                      movie.Producer = movieViewModel.Producer;
                      movie.Description = movieViewModel.Description;
                      //movie.Genre.GenreType = movieViewModel.GenreType;
                      movie.Year = movieViewModel.Year;
                      movie.Seasons = movieViewModel.Seasons;
                      movie.Status = movieViewModel.Status;

          
                    if (movie.MovieId == 0 )
                    {
                        var uniqrow = dbContext.Movie.FirstOrDefault(a => a.Title == movie.Title);

                        if (uniqrow == null)
                        {
                            dbContext.Entry(movie).State = System.Data.Entity.EntityState.Added;
                            dbContext.Movie.Add(movie);
                            
                            
                        }
                    }
                    else
                    {

                        dbContext.Movie.Attach(movie);
                        dbContext.Entry(movie).State = System.Data.Entity.EntityState.Modified;
                    }

                    
                                   
                }

                

                dbContext.SaveChanges();

               MessageBox.Show("Changes saved");
            }

            
            
        }

        private void movieGrid_Click(object sender, EventArgs e)
        {

           


        }

       Movie movie = null;
        private List<MovieGridViewModel> moviesGridViewModel;
        private List<WatchedGridViewModel> watchedMoviesGridViewModel;
        private List<WatchListGridViewModel> watchListGridViewModel;

        // bool removeButtonClicked = false;

        private void buttonRemove_Click(object sender, EventArgs e) 
        {
                                         


          //  removeButtonClicked = true;

            MovieGridViewModel selectedMovie = gridView1.GetRow(gridView1.FocusedRowHandle) as MovieGridViewModel;

            gridView1.DeleteSelectedRows();

              using (var dbContext = new MovieManagerEntities())
             {

               movie = dbContext.Movie.SingleOrDefault(m => m.MovieId == selectedMovie.MovieId);

              dbContext.Entry(movie).State = System.Data.Entity.EntityState.Deleted;

               dbContext.SaveChanges();
            }


        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {

            // load data from db
            LoadData();

            BindDataToGrids();


        }

        private void movieGrid_Click_1(object sender, EventArgs e)
        {

        }

        private void tabNavigationPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPane1_Click(object sender, EventArgs e)
        {

        }

        private void gridWatchList_Click(object sender, EventArgs e)
        {

        }

        private void gridWatched_Click(object sender, EventArgs e)
        {

        }
    }

}
