using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using City.Domain;
using City.Domain.Entities;
using City.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;

namespace CityTest.Controllers
{
    
    public class CardController : Controller
    {
        private readonly DataManager dataManager;

        public CardController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult New()
        {
            CardViewModel model = new CardViewModel { Card = new Card(), TypesCard = dataManager.TypesCard.GetCards() };
            return View(model);
        }

        [HttpPost]
        public IActionResult New(CardViewModel model, Guid TypeID)
        {
            model.Card.TypeCardID=TypeID;
            if (ModelState.IsValid)
            {
                dataManager.Cards.SaveCard(model.Card);
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        public IActionResult More(Guid id)
        {
            return View(dataManager.Cards.GetCard(id));
        }
    }
}
