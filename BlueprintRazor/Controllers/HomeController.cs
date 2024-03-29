﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BlueprintRazor.Models;

namespace BlueprintRazor.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Movies()
    {
        return View();
    }

    
}
