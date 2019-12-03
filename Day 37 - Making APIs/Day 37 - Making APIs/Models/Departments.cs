using System;
using System.Collections.Generic;

namespace Day_37___Making_APIs.Models
{
    public partial class Departments
    {
        public Departments()
        {
            Employees = new HashSet<Employees>();
        }

        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
        public double Budget { get; set; }

        public virtual ICollection<Employees> Employees { get; set; }
    }
}
