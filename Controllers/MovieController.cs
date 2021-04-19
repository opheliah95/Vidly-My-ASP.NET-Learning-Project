using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // changed return type to make unit test easier
        public ActionResult GenerateRandomFilm()
        {
            var movie = new Movie() { name = "Default", ID = 1, price = 30 };
            List<Customer> customers = new List<Customer>
            {
                new Customer{ ID = 1, Name = "C1" },
                new Customer{ ID = 2, Name = "C2"}

            };

            // Create a new view model
            RandomMovieViewModel randViewModel = new RandomMovieViewModel() { Movie = movie, Customers = customers };
            return View(randViewModel);
        }

        public ActionResult Edit (int? id)
        {
            return Content("The parameter is: " + id);
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
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