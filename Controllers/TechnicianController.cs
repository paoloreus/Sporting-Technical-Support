using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assig1ProtoType.Models;

namespace Assig1ProtoType.Controllers
{
    public class TechnicianController : Controller
    {

        private SportContext context { get; set; }
        public TechnicianController(SportContext scx)
        {
            context = scx;
        }
        public IActionResult Index()
        {
            var technicians = context.Technicians
                .OrderBy(t => t.Name)
                .ToList();
            return View(technicians);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var technician = context.Technicians.Find(id);
            return View(technician);
        }

        [HttpPost]
        public IActionResult Edit(Technician technician)
        {
            context.Technicians.Update(technician);
            context.SaveChanges();
            return RedirectToAction("Index", "Technician");
        }

       
    }
}
