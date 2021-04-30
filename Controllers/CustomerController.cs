using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            // populate a dummy list
            List<Customer> customers = GenerateCustomers();
            Movie moive = GenerateMovie();

            // generate a view-model for customer-moive
            RandomMovieViewModel rmv = new RandomMovieViewModel() {Movie = moive, Customers = customers };
            return View(rmv);
        }

        // dummy customer data
        public List<Customer> GenerateCustomers()
        {
            List<Customer> c = new List<Customer> {
                                new Customer { ID = 1, Name = "Doe Joe" },
                                new Customer { ID = 2, Name = "Jane Smith" },
                                };
            return c;
        }

        public Movie GenerateMovie()
        {
            Movie m = new Movie() { ID = 1, name = "Default" };
            return m;
        }
    }
}