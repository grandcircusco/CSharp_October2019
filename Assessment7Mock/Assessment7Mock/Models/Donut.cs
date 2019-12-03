using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment7Mock.Models
{
    public class DonutRoot
    {
        public int Count { get; set; }

        public Donut[] Results { get; set; }
    }

    public class Donut
    {
        public int Id { get; set; }
        public string _ref { get; set; }
        public string Name { get; set; }
        public int Calories { get; set; }
        public string[] Extras { get; set; }
        public string Photo { get; set; }
        public string Photo_attribution { get; set; }
    }

}
