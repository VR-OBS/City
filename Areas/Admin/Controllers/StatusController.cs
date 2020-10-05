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
    public class StatusController : Controller
    {
        
        private readonly DataManager dataManager;

        public StatusController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Edit(Guid id)
        {
            if (id == default)
            {
                return View(new Status());
            }
            return View(dataManager.Statuses.GetCard(id));
        }

        [HttpPost]
        public IActionResult Edit(Status card)
        {
            if (ModelState.IsValid)
            {
                dataManager.Statuses.SaveCard(card);
                return RedirectToAction("Statuses", "Home");
            }
            return View(card);
        }

        public IActionResult Delete(Guid id)
        {
            dataManager.Statuses.DeleteCard(id);
            return RedirectToAction("Statuses", "Home");
        }
    }
}
