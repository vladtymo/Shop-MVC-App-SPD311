using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_App_SPD311.Data;
using MVC_App_SPD311.Models;

namespace MVC_App_SPD311.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly FootballDbContext context;

    public HomeController(ILogger<HomeController> logger, FootballDbContext context)
    {
        _logger = logger;
        this.context = context;
    }

    // GET: ~/home/index
    public IActionResult Index()
    {
        // load data from db
        return View(context.FootballTeams.ToList()); // return View: ~/Home/Index.cshtml
    }

    public IActionResult Privacy()
    {
        return View();
    }
    
    public IActionResult About()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}