using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BlueprintRazor.Models;
using BlueprintRazor.Data;

namespace BlueprintRazor.Controllers;

public class MoviesController : Controller
{
    private DataBaseContext _dataBaseContext;
    public MoviesController(DataBaseContext dataBaseContext)
    {
        _dataBaseContext = dataBaseContext;
    }
    public IActionResult Movies()
    {
        var movies = _dataBaseContext.Movie.ToList();
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
            _dataBaseContext.Movie.Add(movie);
            _dataBaseContext.SaveChanges();
        }
        return RedirectToAction("Movies");
    }

}
