using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameOfLife.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GameOfLife.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new UserInfo();
            HttpContext.Session.SetString("Test", "Session Value");
            return View();
        }

        public IActionResult Game(string user, string color)
        {
            
            return View("Game");
        }

    }
}