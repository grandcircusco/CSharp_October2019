using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Day_37___TestingAPIs.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Day_37___TestingAPIs.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee employee)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44376/");
            var result = await client.PostAsJsonAsync("api/Company", employee);

            return RedirectToAction("Index");
        }
    }
}