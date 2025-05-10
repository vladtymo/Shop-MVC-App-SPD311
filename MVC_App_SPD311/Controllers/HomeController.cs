using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    public async Task<IActionResult> Index([FromQuery] string? name)
    {
        IQueryable<Team> items = context.FootballTeams;
            
        if (name != null)
            items = items.Where(x => x.Name.Contains(name));
            
        return View(await items.ToListAsync());
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