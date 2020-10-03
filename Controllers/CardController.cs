using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using City.Domain;
using City.Domain.Entities;
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
            var card = new Card();
            card.Pos_X = "0";
            card.Pos_Y = "0";
            card.Text = "testc";
            card.Address = "Kaluga";
            dataManager.Cards.SaveCard(card);

            return RedirectToAction("Index", "Home");
        }
    }
}
