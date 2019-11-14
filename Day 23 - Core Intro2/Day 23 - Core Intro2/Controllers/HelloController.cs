using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Day_23___Core_Intro2.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GreetUser(string name, int number)
        {
            ViewData["number"] = number;
            return View("GreetUser", name);
        }
    }
}