using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Day_26___TempData.Controllers
{
    public class TempDataController : Controller
    {
        public IActionResult First()
        {
            TempData["HaroldsKey"] = "HaroldsValue";
            return View();
        }

        public IActionResult Second()
        {
            var harold = TempData["HaroldsKey"];
            return View();
        }

        public IActionResult Third()
        {
            var harold = TempData["HaroldsKey"];
            return View();
        }
    }
}