using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using City.Domain;
using City.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace City.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public  IActionResult Cards()
        {
            return View(dataManager.Cards.GetCards());
        }

        public IActionResult Statuses()
        {
            return View(dataManager.Statuses.GetCards());
        }

        public IActionResult TypesCard()
        {
            return View(dataManager.TypesCard.GetCards());
        }

        public IActionResult Contractors()
        {
            return View(dataManager.Contractors.GetCards());
        }

    }
}
