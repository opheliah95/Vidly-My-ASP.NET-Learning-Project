using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // changed return type to make unit test easier
        public ActionResult GenerateRandomFilm()
        {
            var moive = new Movie() { name = "Default", ID = 1, price = 30 };
            //return Content ("Hello world");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy="name" });
            return View(moive);
        }

        public ActionResult Edit (int? id)
        {
            return Content("The parameter is: " + id);
        }

        [Route("movies/released/{year}/{month::regex(\\d{2})::range(1,12)}")]
        public ActionResult ByReleaseDate(int? year = 2000, int? month = 4)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if(String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("pageIndex={0} and sortBy={1}", pageIndex, sortBy));
        }
    }
} 