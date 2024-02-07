using System.Collections.Generic;
using BlueprintRazor.Models;
using BlueprintRazor.Data;
namespace BlueprintRazor.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private DataBaseContext _dataBaseContext;
        public MovieRepository(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }
        public List<Movie> GetAllMovies()
        {
            List<Movie> movies = new List<Movie>();
            try
            {
                movies = _dataBaseContext.Movie.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return movies;
        }
        public void CreateMovie(Movie movie)
        {
            if (movie != null)
            {
                try
                {
                    _dataBaseContext.Movie.Add(movie);
                    _dataBaseContext.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

            }
        }
    }
}