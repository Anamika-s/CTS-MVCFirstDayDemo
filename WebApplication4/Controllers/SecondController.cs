using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class SecondController : Controller
    {
        public IActionResult Display()
        {
            return View();
        }
    }
}
