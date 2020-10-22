using City.Domain;
using City.Domain.Entities;
using City.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            CardViewModel model = new CardViewModel { Card = dataManager.Cards.GetCard(id), TypesCard = new SelectList(dataManager.TypesCard.GetCards(), "ID", "Name"), Statuses = new SelectList(dataManager.Statuses.GetCards(),"ID","Name"), Contractors = new SelectList(dataManager.Contractors.GetCards(), "ID", "Name") };
            return View("MoreInfo", model);
        }

        [HttpPost]
        public IActionResult Edit(CardViewModel model, IFormFile CardFile)
        {
            if (ModelState.IsValid)
            {
                Card editCard = dataManager.Cards.GetCard(model.Card.ID);
                editCard.StatusID = model.Card.StatusID;
                editCard.TypeCardID = model.Card.TypeCardID;
                editCard.ContractorID = model.Card.ContractorID;
                editCard.EndDate = model.Card.EndDate;
                editCard.Pos_X = model.Card.Pos_X;
                editCard.Pos_Y = model.Card.Pos_Y;
                dataManager.Cards.SaveCard(editCard);
                return RedirectToAction("Cards", "Home");
            }
            return View(model);
        }
        [HttpPost]
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
