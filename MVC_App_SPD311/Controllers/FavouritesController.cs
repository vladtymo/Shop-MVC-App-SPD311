using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVC_App_SPD311.Interfaces;

namespace MVC_App_SPD311.Controllers
{
    public class FavouritesController : Controller
    {
        private readonly IFavoriteService favService;

        public FavouritesController(IFavoriteService favService)
        {
            this.favService = favService;
        }
        
        public ActionResult Index()
        {
            var ids = favService.GetAll();
            return View(ids);
        }

        public ActionResult Add(int id, string? returnUrl)
        {
            favService.Add(id);
            
            return returnUrl != null ?
                Redirect(returnUrl) :
                RedirectToAction("Index", "Home");
        }

        public ActionResult Remove(int id, string? returnUrl)
        {
            favService.Remove(id);
            
            return returnUrl != null ?
                Redirect(returnUrl) :
                RedirectToAction("Index", "Home");
        }
    }
}
