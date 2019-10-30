using System;
using System.Collections.Generic;
using System.Text;

namespace Day_12___Interfaces_Abstract_Classes
{
    class Turkey: Mammal
    {
        public int FeatherCount { get; set; }
        public bool IsMammal
        {
            get { return false; }
        }

        public Turkey(bool warmBlooded, string hairDescription):base(warmBlooded, hairDescription)
        {

        }
        public override void MakeNoise()
        {
            Console.WriteLine("Gobble Gobble");
        }
        public override void Move()
        {
            Console.WriteLine("Trots"); 
        }
    }
}
