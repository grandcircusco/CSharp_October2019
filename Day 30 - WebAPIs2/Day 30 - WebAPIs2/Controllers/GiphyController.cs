using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Day_30___WebAPIs2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day_30___WebAPIs2.Controllers
{
    public class GiphyController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://api.giphy.com/v1/");

            string query = "grandcircusco";

            var response = await client.GetAsync($"gifs/search?api_key=KtzIBT0wezZmVmBDhn7pRxM2nAo4xn1m&q={query}");
            //TODO add ReadAsAsync after nuget package download
            //Nuget package - Microsoft.aspnet.webapi.client

            var giphy = await response.Content.ReadAsAsync<Giphy>();
            return View(giphy);
        }
    }
}