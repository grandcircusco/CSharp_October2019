using System;
using System.Collections.Generic;
using System.Text;

namespace Day_12___Interfaces_Abstract_Classes
{
    class Elephant:Mammal
    {
        public double SnoutLength { get; set; }
        public int TuskCount { get; set; }

        public Elephant(bool warmBlooded, string hairDescription, double snoutlength, int tuskCount) : base(warmBlooded, hairDescription)
        {
            SnoutLength =snoutlength;
            TuskCount = tuskCount;
           
        }

        public override void MakeNoise()
        {

            Console.WriteLine("Rawr");
        }
        public override void Move()
        {
            Console.WriteLine("Trample");
        }
    }
}
