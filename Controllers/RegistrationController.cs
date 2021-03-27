using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GBCSporting2021_TheDevelopers.Models;

namespace GBCSporting2021_TheDevelopers.Controllers
{
    public class RegistrationController : Controller
    {
        public SportContext context;

        public RegistrationController(SportContext scx)
        {
            context = scx;
        }

        [Route("[controller]s/{id?}")]
        [HttpPost]
        public IActionResult Index(int id)
        {
            var session = new RegistrationSession(HttpContext.Session);
            session.SetCustomer(context.Customers.Where(c => c.CustomerId == id).FirstOrDefault());
            ViewBag.Session = session.GetCustomer().FirstName + " " + session.GetCustomer().LastName;
            ViewBag.custId = session.GetCustomer().CustomerId;
            var model = new RegistrationListViewModel
            {
                Registrations = context.Registrations.Where(r => r.CustomerId == id).ToList(),
                Customers = context.Customers.ToList(),
                Products = context.Products.ToList()
            };

            ViewBag.Show = 1;
            return View("Index", model);
        }

        [Route("[controller]s")]
        [HttpGet]
        public IActionResult Index()
        {
            var model = new RegistrationListViewModel
            {
                Products = context.Products.ToList(),
                Customers = context.Customers.ToList(),
                Registrations = context.Registrations.ToList()
            };
            return View(model);
        }

        
    }
}
