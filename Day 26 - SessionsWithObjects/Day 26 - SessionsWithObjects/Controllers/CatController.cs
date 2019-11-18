using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day_26___SessionsWithObjects.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Day_26___SessionsWithObjects.Controllers
{
    public class CatController : Controller
    {
        public List<Cat> savedCats = new List<Cat>();
        public IActionResult Index()
        {
            PopulateFromSession();
            return View(savedCats);
        }

        public IActionResult SaveCat(Cat newCat)
        {
            PopulateFromSession();
            savedCats.Add(newCat);

            HttpContext.Session.SetString("CatListSession", 
                JsonConvert.SerializeObject(savedCats));

            return RedirectToAction("Index");
        }

        public IActionResult ClearCats()
        {
            HttpContext.Session.Remove("CatListSession");
            return RedirectToAction("Index");
        }

        public void PopulateFromSession()
        {
            string catListJson = HttpContext.Session.GetString("CatListSession");
            if(catListJson != null)
            {
                savedCats = JsonConvert.DeserializeObject<List<Cat>>(catListJson);
            }
        }
    }
}