using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_28___EFCoreCodeFirst1.Context
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department(1, "Orphan Employees", "Not found", "Lost", 0.00),
                new Department(2, "Accounting", "East Wing", "Finance", 0.30),
                new Department(3, "Marketing", "West Wing", "Advertising", 5000000.00),
                new Department(4, "Sales", "Sales Floor", "Peons", 16.00)
                );

            modelBuilder.Entity<Employee>().HasData(
                new Employee(1, "Marty", "McFly", "Marty@McFly.co", 3),
                new Employee(2, "Biff", "Tannen", "Tannen@McFly.co", 1),
                new Employee(3, "George", "McFly", "George@McFly.co", 3),
                new Employee(4, "Jennifer", "Parker", "Jennifer@McFly.co", 2),
                new Employee(5, "Emmett", "Brown", "Emmett@Brown.co", 1),
                new Employee(6, "Clara", "Clayton", "Clara@Brown.co", 2)
                );
        }
    }
}
