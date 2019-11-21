using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day_29___Identity_Framework.Data;
using Day_29___Identity_Framework.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day_29___Identity_Framework.Controllers
{
    public class DatabaseController : Controller
    {
        private readonly IdentityFrameworkTestDbContext _dbContext;
        private readonly ApplicationDbContext _identityContext;
        public DatabaseController(IdentityFrameworkTestDbContext dbContext, ApplicationDbContext identityContext)
        {
            _dbContext = dbContext;
            _identityContext = identityContext;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}