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
            return View(dataManager.Cards.GetCards());
        }

        public  IActionResult Cards()
        {
            return View("Cards", dataManager.Cards.GetCards());
        }

        public IActionResult Statuses(string act)
        {
            if(act=="Add")
            {
                return View("AddEditStatus",new Status());
            }
            return View("Statuses", dataManager.Statuses.GetCards());
        }

        [HttpPost]
        public IActionResult Statuses(Status card)
        {
            if (ModelState.IsValid)
            {
                dataManager.Statuses.SaveCard(card);
                return RedirectToAction("Statuses", "Home");
            }
            return View(card);
        }



    }
}
