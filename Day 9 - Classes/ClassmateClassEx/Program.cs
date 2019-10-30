using System;
using System.Collections.Generic;

namespace ClassmateClassEx
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Classmate> classList = new List<Classmate>
            {
                new Classmate("Bill", "Buffalo", "Buffalo Chicken Wings", "Football", 7),
                new Classmate("Stitch", "Hawaii", "All of it", "Finding his family", 626),
                new Classmate("Oliver", "Wales", "Crepes", "Playing the banjo", 4),
            };

            foreach(Classmate classmate in classList)
            {
                classmate.PrintInfo();
            }
        }
    }
}
