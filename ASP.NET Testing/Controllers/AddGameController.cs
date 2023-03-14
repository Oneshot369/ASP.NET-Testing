using ASP.NET_Testing.Data;
using ASP.NET_Testing.Models;
using ASP.NET_Testing.Depend;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Testing.Controllers
{
    public class AddGameController : Controller
    {
        MongoGameDAO GameDAO = new MongoGameDAO();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowGame(Game gameToAdd)
        {
            GameDAO.Create(gameToAdd);
            return View(gameToAdd);
        }
    }
}
