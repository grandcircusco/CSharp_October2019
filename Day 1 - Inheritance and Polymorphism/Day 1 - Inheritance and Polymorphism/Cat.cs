using System;
using System.Collections.Generic;
using System.Text;

namespace Day_1___Inheritance_and_Polymorphism
{
    class Cat : Animal
    {
        public int HoursSlept { get; set; }

        public Cat(string name) : base(name)
        {

        }

        public Cat(string name, int hoursSlept): base(name)
        {
            HoursSlept = hoursSlept;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says \"meow\"!");
        }

        public void AddHoursSlept()
        {
            if(HoursSlept >= 24)
            {
                Console.WriteLine("Is it alive?");
            }
            else
            {
                HoursSlept++;
            }
        }
    }
}
