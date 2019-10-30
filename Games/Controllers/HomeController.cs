using Microsoft.AspNetCore.Mvc;
using Games.Models;
using System;

namespace Games.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Index()
        {
            var allGames = Game.GetGames();
            return View(allGames);
        }
    }
}
