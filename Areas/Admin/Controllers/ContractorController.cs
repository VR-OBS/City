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
    public class ContractorController : Controller
    {
              
        private readonly DataManager dataManager;

        public ContractorController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Edit(Guid id)
        {
            if (id == default)
            {
                return View(new Contractor());
            }
            return View(dataManager.Contractors.GetCard(id));
        }

        [HttpPost]
        public IActionResult Edit(Contractor card)
        {
            if (ModelState.IsValid)
            {
                dataManager.Contractors.SaveCard(card);
                return RedirectToAction("Contractors", "Home");
            }
            return View(card);
        }

        public IActionResult Delete(Guid id)
        {
            dataManager.Contractors.DeleteCard(id);
            return RedirectToAction("Contractors", "Home");
        }
    }
}
