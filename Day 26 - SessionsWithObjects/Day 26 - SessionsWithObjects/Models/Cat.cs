using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_26___SessionsWithObjects.Models
{
    public class Cat
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }

        public Cat(string name, string color, int age)
        {
            Name = name;
            Color = color;
            Age = age;
        }
        public Cat() { }
    }
}
