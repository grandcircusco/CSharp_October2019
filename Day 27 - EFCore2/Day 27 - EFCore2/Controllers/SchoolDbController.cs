using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day_27___EFCore2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day_27___EFCore2.Controllers
{
    public class SchoolDbController : Controller
    {
        private readonly SchoolDbContext _context;

        public SchoolDbController(SchoolDbContext context)
        {
            _context = context;
        }

        public IActionResult ListPeople()
        {
            var personList = _context.Person.ToList();
            return View(personList);
        }

        [HttpGet]
        public IActionResult AddNewPerson()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewPerson(Person newPerson, string StudentOrInstructor)
        {
            if (ModelState.IsValid)
            {
                _context.Person.Add(newPerson);
                _context.SaveChanges();

                //TempData["NewPersonId"] = newPerson.Id;

                //if(StudentOrInstructor == "student")
                //{
                //    return View("AddStudent");
                //}
                //else
                //{
                //    return View("AddInstructor");
                //}
            }
            return RedirectToAction("ListPeople");
        }

        public IActionResult RemovePerson(int id)
        {
            Person foundPerson = _context.Person.Find(id);
            _context.Remove(foundPerson);
            _context.SaveChanges();
            return RedirectToAction("ListPeople");
        }
    }
}