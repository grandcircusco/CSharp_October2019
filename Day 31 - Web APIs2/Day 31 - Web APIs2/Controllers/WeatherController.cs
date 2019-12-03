using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Day_31___Web_APIs2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day_31___Web_APIs2.Controllers
{
    public class WeatherController : Controller
    {
        public async Task<IActionResult> DisplayWeather()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://weatherbit-v1-mashape.p.rapidapi.com");
            client.DefaultRequestHeaders.Add("x-rapidapi-host", "weatherbit-v1-mashape.p.rapidapi.com");
            client.DefaultRequestHeaders.Add("x-rapidapi-key", "Afnzr4pk72mshUNIhIIYfjrpdY8Zp1qV7OKjsncttkrAgYLSK7");
            var response = await client.GetAsync("/current?lang=en&lon=28.3852&lat=81.5639");
            var weather = await response.Content.ReadAsAsync<WeatherRoot>();

            return View();
        }
    }
}