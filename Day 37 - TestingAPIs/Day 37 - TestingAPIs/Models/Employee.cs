using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_37___TestingAPIs.Models
{

    public class EmployeeRoot
    {
        public Employee[] Property1 { get; set; }
    }

    public class Employee
    {
        public int employeeId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public int departmentId { get; set; }
        public object department { get; set; }
    }

}
