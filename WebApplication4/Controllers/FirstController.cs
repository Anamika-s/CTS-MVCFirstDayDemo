using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult first()
        {
            return View();
        }

        public string second()
        {
            return "This is a string";
        }

        public IActionResult third()
        {
            return RedirectToAction("Index");
        }

        public IActionResult fourth()
        {
            return RedirectToAction("index", "home");
        }

        public IActionResult fifth()
        {
            ViewBag.data = "Batch Code is B001";
            ViewData["name"] = "Ajay Sood";
            return View();
        }
    }
}
