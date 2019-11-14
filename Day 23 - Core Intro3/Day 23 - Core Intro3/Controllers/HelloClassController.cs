using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day_23___Core_Intro3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day_23___Core_Intro3.Controllers
{
    public class HelloClassController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GreetUser(User user)
        {
            return View(user);
        }
    }
}