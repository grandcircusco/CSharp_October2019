using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day_24___Core_Day_2._1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day_24___Core_Day_2._1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddStudent()
        {
            return View();
        }

        public IActionResult DisplayStudent(Student newStudent)
        {
            if (ModelState.IsValid)
            {
                return View(newStudent);
            }
            else
            {
                return View("AddStudent");
            }
        }
    }
}