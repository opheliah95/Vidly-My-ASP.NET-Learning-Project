using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
namespace Vidly.Controllers
{
    public class MoiveController : Controller
    {
        // GET: Moive/Random
        public ActionResult GenerateRandomFilm()
        {
            var moive = new Moive() { name = "Default", ID = 1, price = 30 };
            return View(moive);
        }
    }
}