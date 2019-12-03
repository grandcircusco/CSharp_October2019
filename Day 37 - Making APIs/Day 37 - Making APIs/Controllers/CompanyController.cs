using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day_37___Making_APIs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Day_37___Making_APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly CompanyDbOct2019Context _context;
        public CompanyController(CompanyDbOct2019Context context)
        {
            _context = context;
        }

        //GET: api/Company
        [HttpGet]
        public async Task<ActionResult<List<Employees>>> GetEmployees()
        {
            return await _context.Employees.ToListAsync();
        }

        //GET: api/Company/1
        [HttpGet("{id}")]
        public async Task<ActionResult<Employees>> GetEmployeeById(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if(employee == null)
            {
                return NotFound();
            }
            return employee;
        }

        //POST: api/Company
        [HttpPost]
        public async Task<ActionResult<Employees>> PostEmployee(Employees employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEmployeeById), new { id = employee.EmployeeId }, employee);
            //return HTTP 201 status code if successful. 
            //This is the standard response for HTTP Post method that creates a new resource on the server
            //2. Adds a location header to the response, speifies the URI of the newly created employee
            //3. references the GetEmployeeById action to create the locaation header's URI.
            //      C# "nameof" is used to avoid hard-coding the action in the CreatedAtAction call
        }

        //PUT: api/Company/{id}

        [HttpPut("{id}")]
        public async Task<ActionResult> PutEmployee(int id, Employees employee) 
        {
            if(id != employee.EmployeeId)
            {
                return BadRequest();
            }

            _context.Entry(employee).State = EntityState.Modified;

            await _context.SaveChangesAsync();
            return NoContent();
            //RESPONSE: 204 (No content) - requires the client to send an entirely updated entity and not just the changes
            //to support partial updates, we would use HTTP Patch
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteEmployee(int id)
        {

            var employee = await _context.Employees.FindAsync(id);
            if(employee == null)
            {
                return NotFound();
            }

            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}