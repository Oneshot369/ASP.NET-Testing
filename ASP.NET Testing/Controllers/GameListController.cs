﻿using ASP.NET_Testing.Data;
using ASP.NET_Testing.Depend;
using ASP.NET_Testing.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace ASP.NET_Testing.Controllers
{
    public class GameListController : Controller
    {
        IGameData GameDAO = DataSource.getDataSource();
        public IActionResult Index()
        {
            return View(GameDAO.getAllGames());
        }
    }
}
