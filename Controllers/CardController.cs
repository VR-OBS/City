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
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Hosting.Internal;

namespace CityTest.Controllers
{
    
    public class CardController : Controller
    {
        private readonly DataManager dataManager;
        IWebHostEnvironment _appEnvironment;

        public CardController(DataManager dataManager, IWebHostEnvironment appEnvironment)
        {
            this.dataManager = dataManager;
            this._appEnvironment = appEnvironment;
        }
        public IActionResult New()
        {
            CardViewModel model = new CardViewModel { Card = new Card(), TypesCard = new SelectList(dataManager.TypesCard.GetCards(), "ID", "Name") };
            return View(model);
        }

        [HttpPost]
        public IActionResult New(CardViewModel model, IFormFile CardPhoto)
        {
            if (ModelState.IsValid)
            {
                if (CardPhoto != null)
                {
                    model.Card.PhotoPath = Guid.NewGuid()+"";
                    using (var fileStream = new FileStream(Path.Combine(_appEnvironment.WebRootPath, "CardImages/", model.Card.PhotoPath+"_before.jpg"), FileMode.Create))
                    {
                        CardPhoto.CopyTo(fileStream);
                    }
                }
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
