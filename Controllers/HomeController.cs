﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;

namespace MVCProject.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        HomeModel home = new HomeModel();

        home.Nome = "Nicolas Calheiros Maciel";
        home.Email = "nicolascm12@gmail.com";

        return View(home);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
