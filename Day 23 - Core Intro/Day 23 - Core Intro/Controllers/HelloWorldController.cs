using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Day_23___Core_Intro.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            string name = "Grant Chirpus";
            return View("Index", name);
        }
    }
}