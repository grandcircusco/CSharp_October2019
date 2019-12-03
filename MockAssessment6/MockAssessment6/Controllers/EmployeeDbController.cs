using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MockAssessment6.Models;

namespace MockAssessment6.Controllers
{
    public class EmployeeDbController : Controller
    {
        private readonly EmployeeDbContext _context;

        public EmployeeDbController(EmployeeDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DisplayEmployees()
        {
            List<Employee> employees = _context.Employee.ToList();
            return View(employees);
        }
        public IActionResult RetirementInfo(int id)
        {
            Employee employeeId = _context.Employee.Find(id);
            if(employeeId.Age > 60)
            {
                ViewBag.CanRetire = true;
            }
            else
            {
                ViewBag.CanRetire = false;
            }
            ViewBag.Benefits = (double)employeeId.Salary * .60;
            return View();
        }
    }
}