using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assessment7Mock.Models;
using System.Net.Http;

namespace Assessment7Mock.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        //    This was for creating a list of Donut names to use a drop - down selecton
        //     in the View.This is not part of the Mock Assessment.

        //public async Task<IActionResult> Index()
        //{



        //   HttpClient client = new HttpClient();

        //    var response = await client.GetAsync($"https://grandcircusco.github.io/demo-apis/donuts.json");
        //    var results = await response.Content.ReadAsAsync<DonutRoot>();

        //    return View(results);           
        //}

        public async Task<IActionResult> Search(int id)
        {
            HttpClient client = new HttpClient();

            var response = await client.GetAsync($"https://grandcircusco.github.io/demo-apis/donuts/{id}.json");
            var results = await response.Content.ReadAsAsync<Donut>();

            return View(results);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
