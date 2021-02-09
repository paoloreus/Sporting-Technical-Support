using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assig1ProtoType.Models;

namespace Assig1ProtoType.Controllers
{
    public class IncidentController : Controller
    {
        private SportContext context { get; set; }
        public IncidentController(SportContext scx)
        {
            context = scx;
        }
        public IActionResult Index()
        {
            var incidents = context.Incidents
                .Include(c => c.Customer)
                .Include(p => p.Product)
                .Include(t => t.Technician)
                .OrderBy(i => i.Title)
                .ToList();
            return View(incidents);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Customers = context.Customers.OrderBy(c => c.Name).ToList();
            ViewBag.Products = context.Products.OrderBy(p => p.Name).ToList();
            ViewBag.Technicians = context.Technicians.OrderBy(t => t.Name).ToList();
            var incident = context.Incidents.Find(id);
            return View(incident);
        }

        [HttpPost]
        public IActionResult Edit(Incident incident)
        {
            context.Incidents.Update(incident);
            context.SaveChanges();
            return RedirectToAction("Index", "Incident");
        }
    }
}
