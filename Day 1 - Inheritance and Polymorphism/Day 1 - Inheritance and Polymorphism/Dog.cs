using System;
using System.Collections.Generic;
using System.Text;

namespace Day_1___Inheritance_and_Polymorphism
{
    class Dog : Animal
    {
        public int SticksFetched { get; set; }

        public Dog(string name, int sticksFetched)
            : base(name)
        {
            this.SticksFetched = sticksFetched;
        }

        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine($"{Name} says \"Woof\"!");
        }

        public void FetchAStick()
        {
            SticksFetched++;
        }

    }
}
