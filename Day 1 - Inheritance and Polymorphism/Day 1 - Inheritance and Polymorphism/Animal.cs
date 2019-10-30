using System;
using System.Collections.Generic;
using System.Text;

namespace Day_1___Inheritance_and_Polymorphism
{
    class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            this.Name = name;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("I make a noise.");
        }
    }
}
