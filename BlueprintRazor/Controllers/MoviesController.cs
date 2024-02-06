using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BlueprintRazor.Models;

namespace BlueprintRazor.Controllers;

public class MoviesController : Controller
{
    
    public IActionResult Movies()
    {
        return View();
    }

   
}
