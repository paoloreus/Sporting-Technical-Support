using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assig1ProtoType.Models;

namespace Assig1ProtoType.Controllers
{
    public class ProductController : Controller
    {
        private SportContext context { get; set; }
        
        public ProductController(SportContext scx)
        {
            context = scx;
        }
        public IActionResult Index()
        {
            var products = context.Products
                .OrderBy(p => p.Name)
                .ToList();
            return View(products);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var product = context.Products.Find(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            context.Products.Update(product);
            context.SaveChanges();
            return RedirectToAction("Index", "Product");
        }
    }
}
