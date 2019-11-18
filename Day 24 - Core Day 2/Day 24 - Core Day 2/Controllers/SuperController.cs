using Day_24___Core_Day_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day_24___Core_Day_2.Controllers
{
    public class SuperController : Controller
    {
      

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DisplaySupers(string selection)
        {
            if(selection == "Heros")
            {
                DataClass.FillPowers(DataClass.superHeros);
                return View(DataClass.superHeros);
            }
            else
            {
                DataClass.FillPowers(DataClass.superVillains);
                return View(DataClass.superVillains);
            }
        }

        [HttpGet]
        public IActionResult AddSuper()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSuper(Supers newSuper)
        {
            if (ModelState.IsValid)
            {
                if (newSuper.GoodOrBad)
                {
                    DataClass.superHeros.Add(newSuper);
                    return View("DisplaySupers", DataClass.superHeros);
                }
                else
                {
                    DataClass.superVillains.Add(newSuper);
                    return View("DisplaySupers", DataClass.superVillains);
                }
            }
            else
            {
                return View();
            }
        }
    }
}