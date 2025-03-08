using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_App_SPD311.Data;

namespace MVC_App_SPD311.Controllers
{
    public class PlayersController : Controller
    {
        private readonly FootballDbContext context;

        public PlayersController()
        {
            context = new FootballDbContext();
        }
        
        // GET: PlayersController
        public ActionResult Index()
        {
            var players = context.FootballPlayers
                .Include(x => x.Team)
                .ToList();
            
            return View(players); 
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
    }
}
