using System;
using System.Collections.Generic;
using System.Linq;
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
            return View(dataManager.Cards.GetCards());
        }
    }
}
