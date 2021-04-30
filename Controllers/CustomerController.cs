using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            // populate a dummy list
            List<Customer> customers = GenerateCustomers();
            return View();
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
    }
}