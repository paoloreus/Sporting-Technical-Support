using Assig1ProtoType.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Assig1ProtoType.Controllers
{
    public class HomeController : Controller
    {
        private SportContext context { get; set; }
        
        public HomeController(SportContext scx)
        {
            context = scx;
        }

        public IActionResult Index()
        {
            return View();
        }


     
    }
}
