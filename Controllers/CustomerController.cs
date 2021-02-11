using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assig1ProtoType.Models;

namespace Assig1ProtoType.Controllers
{
    public class CustomerController : Controller
    {
        private SportContext context;

        public CustomerController(SportContext scx)
        {
            context = scx;
        }
        public IActionResult Index()
        {
            var customers = context.Customers
                .OrderBy(c => c.Name)
                .ToList();
            return View(customers);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Customer());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var customer = context.Customers.Find(id);
            return View(customer);
        }

        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                if(customer.CustomerId == 0)
                {
                    context.Customers.Add(customer);
                }
                else
                {
                    context.Customers.Update(customer);
                }
                context.SaveChanges();
                return RedirectToAction("Index", "Customer");
            }
            else
            {
                if(customer.CustomerId == 0)
                {
                    ViewBag.Action = "Add";
                }
                else
                {
                    ViewBag.Action = "Edit";
                }
                return View(customer);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Customer customer = context.Customers.Find(id);
            return View(customer);

        }

        [HttpPost]
        public IActionResult Delete(Customer customer)
        {
            context.Customers.Remove(customer);
            context.SaveChanges();
            return RedirectToAction("Index", "Customer");
        }
    }
}
