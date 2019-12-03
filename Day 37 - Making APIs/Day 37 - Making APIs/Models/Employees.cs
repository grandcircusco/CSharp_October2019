using System;
using System.Collections.Generic;

namespace Day_37___Making_APIs.Models
{
    public partial class Employees
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int DepartmentId { get; set; }

        public virtual Departments Department { get; set; }
    }
}
