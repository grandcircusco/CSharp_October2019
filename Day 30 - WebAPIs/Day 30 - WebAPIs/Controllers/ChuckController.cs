using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Day_30___WebAPIs.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day_30___WebAPIs.Controllers
{
    public class ChuckController : Controller
    {
        public async Task<IActionResult> ChuckJoke()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://api.icndb.com");

            var response = await client.GetAsync("jokes/random");
            var joke = await response.Content.ReadAsAsync<Chuck>();

            return View(joke);
        }

        public async Task<IActionResult> UserNameJoke(string FirstName, string LastName)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://api.icndb.com");

            var response = await client.GetAsync($"jokes/random?firstName={FirstName}&lastName={LastName}");
            var joke = await response.Content.ReadAsAsync<Chuck>();
            return View("ChuckJoke", joke);
        }
    }
}