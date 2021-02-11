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
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Technician());
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
            if (ModelState.IsValid)
            {
                if(technician.TechnicianId == 0)
                {
                    context.Technicians.Add(technician);
                }
                else
                {
                    context.Technicians.Update(technician);
                }
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                if(technician.TechnicianId == 0)
                {
                    ViewBag.Action = "Add";
                }
                else
                {
                    ViewBag.Action = "Edit";
                }
                return View(technician);
            }
        }

       
    }
}
