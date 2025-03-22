using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_App_SPD311.Data;
using MVC_App_SPD311.Models;

namespace MVC_App_SPD311.Controllers
{
    public class PlayersController : Controller
    {
        private readonly FootballDbContext context;

        public PlayersController(FootballDbContext context)
        {
            this.context = context;
        }
        
        // GET: PlayersController
        public ActionResult Index()
        {
            var players = context.FootballPlayers
                .Include(x => x.Team)
                .ToList();
            
            return View(players); 
        }

        [HttpGet]
        public ActionResult Create()
        {
            LoadTeams();
            return View();
        }
        
        [HttpPost]
        public ActionResult Create(Player player)
        {
            if (!ModelState.IsValid)
            {
                LoadTeams();
                return View();
            }
            
            context.FootballPlayers.Add(player);
            context.SaveChanges();
            
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var player = context.FootballPlayers.Find(id);   
            if (player == null) return NotFound();
            
            LoadTeams();
            return View(player);
        }
        
        [HttpPost]
        public ActionResult Edit(Player player)
        {
            if (!ModelState.IsValid)
            {
                LoadTeams();
                return View();
            }
            
            context.FootballPlayers.Update(player);
            context.SaveChanges();
            
            return RedirectToAction("Index");
        }
        
        public ActionResult Delete(int id)
        {
            var player = context.FootballPlayers.Find(id);   
            if (player == null) return NotFound();
            
            context.FootballPlayers.Remove(player);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
        
        public ActionResult Details(int id)
        {
            var player = context.FootballPlayers
                .Include(x => x.Team)
                .FirstOrDefault(x => x.Id == id);   
            
            if (player == null) return NotFound();

            return View(player);
        }

        private void LoadTeams()
        {
            var teams = new SelectList(context.FootballTeams.ToList(), "Id", "Name");
            ViewBag.Teams = teams;
        }
    }
}
