using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using City.Domain;
using City.Domain.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
            return View(dataManager.Cards.GetCard(id));
        }
        
        [HttpPost]
        public IActionResult Edit(Card card, IFormFile CardFile)
        {
            if (ModelState.IsValid)
            {
                dataManager.Cards.SaveCard(card);
                return RedirectToAction("Index", "Home");
            }
            return View(card);
        }
        
        public IActionResult Delete(Guid id)
        {
            dataManager.Cards.DeleteCard(id);
            return RedirectToAction("Index","Home");
        }
    }
}
