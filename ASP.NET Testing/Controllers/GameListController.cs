using ASP.NET_Testing.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace ASP.NET_Testing.Controllers
{
    public class GameListController : Controller
    {
        public IActionResult Index()
        {
            List<Game> games = new List<Game>();
            games.Add(new Game("001", "Leage of Ledgens", "MOBA", 0.0f, 'E'));
            games.Add(new Game("002", "Destiny", "FPS, RPG, MMO", 0.0f, 'T'));
            games.Add(new Game("003", "ARK", "Survial", 60.0f, 'M'));
            return View(games);
        }
    }
}
