using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day_28___EFCoreCodeFirst1.Context;
using Microsoft.AspNetCore.Mvc;

namespace Day_28___EFCoreCodeFirst1.Controllers
{
    public class CompanyDbController : Controller
    {
        private readonly CompanyDbContext _context;

        public CompanyDbController(CompanyDbContext context)
        {
            _context = context;
        }

        public IActionResult DepartmentIndex()
        {
            return View(_context.Departments.ToList());
        }
        public IActionResult ListEmployeesByDepartment(int id)
        {
            var employees = _context.Employees.Where(employee => employee.DepartmentId == id).ToList();
            return View(employees);
        }
        [HttpGet]
        public IActionResult AddDepartment()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDepartment(Department department)
        {
            if (ModelState.IsValid)
            {
                _context.Departments.Add(department);
                _context.SaveChanges();
                return RedirectToAction("DepartmentIndex");
            }
            return View();
        }
        
        [HttpGet]
        public IActionResult UpdateDepartment(int id)
        {

            return View(_context.Departments.Find(id));
        }

        [HttpPost]
        public IActionResult UpdateDepartment(Department newDepartment)
        {
            if (ModelState.IsValid)
            {
                Department oldDepartment = _context.Departments.Find(newDepartment.DepartmentId);
                oldDepartment.Name = newDepartment.Name;
                oldDepartment.Location = newDepartment.Location;
                oldDepartment.Budget = newDepartment.Budget;
                oldDepartment.Type = newDepartment.Type;

                _context.Entry(oldDepartment).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

                _context.Update(oldDepartment);
                _context.SaveChanges();
            }
            return RedirectToAction("DepartmentIndex");
        }

        public IActionResult DeleteDepartment(int id)
        {
            var foundDepartment = _context.Departments.Find(id);
            if(foundDepartment != null)
            {
                MoveEmployees(id);
                _context.Departments.Remove(foundDepartment);
                _context.SaveChanges();
            }
            return RedirectToAction("DepartmentIndex");
        }

        private void MoveEmployees(int id)
        {
            var employees = _context.Employees.Where(employee => employee.DepartmentId == id).ToList();
            foreach(Employee employee in employees)
            {
                employee.DepartmentId = 5;
            }
        }
    }
}