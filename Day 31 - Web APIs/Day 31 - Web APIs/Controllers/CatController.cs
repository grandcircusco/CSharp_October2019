using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Day_31___Web_APIs.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day_31___Web_APIs.Controllers
{
    public class CatController : Controller
    {
        public async Task<IActionResult> DisplayCategories()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://api.thecatapi.com/v1/");
            client.DefaultRequestHeaders.Add("x-api-key", "48bc7bd6-427e-4d25-b609-3d04dfdbea9b");
            var response = await client.GetAsync("categories");
            //INSTALL Microsoft.AspNet.WebAPI.Client Nuget Package
            var categories = await response.Content.ReadAsAsync<List<Class1>>();
            return View(categories);
        }

        public async Task<IActionResult> DisplayByCategory(string category)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://api.thecatapi.com/v1/");
            client.DefaultRequestHeaders.Add("x-api-key", "48bc7bd6-427e-4d25-b609-3d04dfdbea9b");
            //TODO = find the Get method for cat by category
            var response = await client.GetAsync($"images/search?category_ids={category}");
            //TODO = create the Cat class via the Json from the Cat API documentation
            var cat = await response.Content.ReadAsAsync<List<Cats>>();
            var thisCat = cat[0].height;
            return View(thisCat);
        }
    }
}