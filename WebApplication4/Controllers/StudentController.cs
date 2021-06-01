using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;
namespace WebApplication4.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            Student student = new Student() { Id = 1, Name = "Deepak", Batch = "B001", Marks = 90 };
            ViewBag.student = student;
            return View();
        }

        public IActionResult Display()
        {
            Student student = new Student() { Id = 1, Name = "Deepak", Batch = "B001", Marks = 90 };
            
            return View(student);
        }
    }
}
