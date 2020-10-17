using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
using City.Domain;
using City.Domain.Entities;
using City.Models;
using Microsoft.AspNetCore.Mvc;

namespace City.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index()
        {
            ViewBag.Num1 = dataManager.Cards.GetCards().Where(p => p.StatusID == new Guid("00000000000000000000000000000001")).Count();
            ViewBag.Num = dataManager.Cards.GetCards().Count();
            return View(dataManager.Cards.GetCards());
        }
    }
}
