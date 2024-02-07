using System.Collections.Generic;
using BlueprintRazor.Models;

namespace BlueprintRazor.Repository
{
    public interface IMovieRepository
    {
        public List<Movie> GetAllMovies();
        public void CreateMovie(Movie movie);
    }
}