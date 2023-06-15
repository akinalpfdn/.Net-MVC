using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Basics.Models;

namespace Basics.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
//Coding by convention, these methods refer to html files in views/home folder
    public IActionResult Index()//These Are called Action
    {
        return View();
    }

    public IActionResult Privacy()//These Are called Action
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
