using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BlueprintRazor.Models;
using BlueprintRazor.Data;
using BlueprintRazor.Repository;

namespace BlueprintRazor.Controllers;

public class MoviesController : Controller
{
    private IMovieRepository _movieRepository;
    public MoviesController( IMovieRepository movieRepository )
    {
        _movieRepository= movieRepository;
    }
    public IActionResult Movies()
    {
        var movies = _movieRepository.GetAllMovies();
        return View(movies);
    }
    // Show CreateMovie page
    public IActionResult CreateMovie()
    {
        return View();
    }
    // Perform Create Action
    [HttpPost]
    public IActionResult CreateMovie(Movie movie)
    {
        if (movie != null)
        {
            _movieRepository.CreateMovie(movie);
        }
        return RedirectToAction("Movies");
    }

}
