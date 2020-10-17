using City.Domain;
using City.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace City.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CardController : Controller
    {
        private readonly DataManager dataManager;
        public CardController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Edit(Guid id)
        {
            if (id == default)
            {
                return View(new Card());
            }
            return View("MoreInfo",dataManager.Cards.GetCard(id));
        }

        [HttpPost]
        public IActionResult Edit(Card card, IFormFile CardFile)
        {
            if (ModelState.IsValid)
            {
                dataManager.Cards.SaveCard(card);
                return RedirectToAction("Cards", "Home");
            }
            return View(card);
        }

        public IActionResult Delete(Guid id)
        {
            dataManager.Cards.DeleteCard(id);
            return RedirectToAction("Cards", "Home");
        }

        public IActionResult MoreInfo()
        {
            Card qwe = dataManager.Cards.GetCard(new Guid("8cdddd0b-0419-412d-f6fe-08d86bc94b80"));
            return View(qwe);
        }
    }
}
