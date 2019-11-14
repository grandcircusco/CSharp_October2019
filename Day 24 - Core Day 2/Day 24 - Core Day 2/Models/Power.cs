using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_24___Core_Day_2.Models
{
    public class Power
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string Description { get; set; }


        public Power(string name, int level, string description)
        {
            Name = name;
            Level = level;
            Description = description;

        }
    }
}
