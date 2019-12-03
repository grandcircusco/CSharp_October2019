using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Day_31___Breweries_Exercise.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day_31___Breweries_Exercise.Controllers
{
    public class BreweryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> DisplayBreweriesByState(string BrewState)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://brianiswu-open-brewery-db-v1.p.rapidapi.com");
            client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "brianiswu-open-brewery-db-v1.p.rapidapi.com");
            client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "Afnzr4pk72mshUNIhIIYfjrpdY8Zp1qV7OKjsncttkrAgYLSK7");
            var response = await client.GetAsync($"/breweries?by_state={BrewState}");
            //INSTALL Microsoft.AspNet.WebAPI.Client Nuget Package
            var breweries = await response.Content.ReadAsAsync<List<Brewery>>();
            return View(breweries);
        }
    }
}