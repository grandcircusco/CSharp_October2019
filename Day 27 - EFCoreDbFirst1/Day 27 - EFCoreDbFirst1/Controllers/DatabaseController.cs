using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day_27___EFCoreDbFirst1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day_27___EFCoreDbFirst1.Controllers
{
    public class DatabaseController : Controller
    {
        private readonly NorthwindContext _context;
        public DatabaseController(NorthwindContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var employeeList = _context.Employees.ToList();
            return View(employeeList);
        }
    }
}