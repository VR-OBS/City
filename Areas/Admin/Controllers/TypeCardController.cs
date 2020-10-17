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
    public class TypeCardController : Controller
    {
        private readonly DataManager dataManager;

        public TypeCardController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Edit(Guid id)
        {
            if (id == default)
            {
                return View(new TypeCard());
            }
            return View(dataManager.TypesCard.GetCard(id));
        }

        [HttpPost]
        public IActionResult Edit(TypeCard card)
        {
            if (ModelState.IsValid)
            {
                dataManager.TypesCard.SaveCard(card);
                return RedirectToAction("TypesCard", "Home");
            }
            return View(card);
        }

        public IActionResult Delete(Guid id)
        {
            dataManager.TypesCard.DeleteCard(id);
            return RedirectToAction("TypesCard", "Home");
        }
    }
}
