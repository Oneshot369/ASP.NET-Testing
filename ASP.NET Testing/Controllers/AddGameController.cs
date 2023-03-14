using ASP.NET_Testing.Data;
using ASP.NET_Testing.Models;
using ASP.NET_Testing.Depend;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Testing.Controllers
{
    public class AddGameController : Controller
    {
        IGameData GameDAO = DataSource.getDataSource();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowGame(Game gameToAdd)
        {
            GameDAO.addGame(gameToAdd);
            return View(gameToAdd);
        }
    }
}
