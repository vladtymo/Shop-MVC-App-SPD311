using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_App_SPD311.Data;
using MVC_App_SPD311.Extensions;
using MVC_App_SPD311.Models;

namespace MVC_App_SPD311.Controllers
{
    [Authorize(Roles = Roles.ADMIN)]
    public class TeamsController : Controller
    {
        private readonly FootballDbContext _context;
        private readonly IEmailSender _emailSender;

        public TeamsController(FootballDbContext context, IEmailSender emailSender)
        {
            _context = context;
            _emailSender = emailSender;
        }

        // GET: Teams
        public async Task<IActionResult> Index()
        {
            return View(await _context.FootballTeams.ToListAsync());
        }

        // GET: Teams/Details/5
        public async Task<IActionResult> Details(int? id, string? returnUrl = null)
        {
            if (id == null) return NotFound();

            var team = await _context.FootballTeams.FindAsync(id);
            
            if (team == null) return NotFound(); // 404

            ViewBag.ReturnUrl = returnUrl;
            return View(team);
        }

        // GET: Teams/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Teams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Logo,Name,Players,Country")] Team team)
        {
            if (!ModelState.IsValid) return View(team);
            
            _context.Add(team);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Teams/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var team = await _context.FootballTeams.FindAsync(id);
            if (team == null) return NotFound();
            
            return View(team);
        }

        // POST: Teams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Logo,Name,Players,Country")] Team team)
        {
            if (id != team.Id) return NotFound();

            if (!ModelState.IsValid) return View(team);
            
            _context.Update(team);
            await _context.SaveChangesAsync();
            
            return RedirectToAction(nameof(Index));
        }

        // GET: Teams/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var team = await _context.FootballTeams.FindAsync(id);
            
            if (team == null) return NotFound();
            
            await _emailSender.SendEmailAsync("tymo.vlad@gmail.com", "Deleting team", 
                "<h1>Team on deleting...</h1><p>" + team.Name + "</p>");

            return View(team);
        }

        // POST: Teams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var team = await _context.FootballTeams.FindAsync(id);
            if (team == null) return NoContent();
            
            _context.FootballTeams.Remove(team);
            await _context.SaveChangesAsync();
            
            return RedirectToAction(nameof(Index));
        }

        private bool TeamExists(int id)
        {
            return _context.FootballTeams.Any(e => e.Id == id);
        }
    }
}
