using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using City.Models;
using Microsoft.AspNetCore.Mvc;

namespace City.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new CardView());
        }
    }
}
