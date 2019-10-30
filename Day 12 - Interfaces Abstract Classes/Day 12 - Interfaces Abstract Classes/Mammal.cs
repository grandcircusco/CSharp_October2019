using System;
using System.Collections.Generic;
using System.Text;

namespace Day_12___Interfaces_Abstract_Classes
{
    abstract class Mammal
    {
        public bool WarmBlooded { get; set; }
        public string HairDescription { get; set; }

        public Mammal()
        {

        }
        public Mammal(bool warmBlooded, string hairDescription)
        {
            this.WarmBlooded = warmBlooded;
            this.HairDescription = hairDescription;
        }

        public abstract void MakeNoise();
        public abstract void Move();

        public void BeAMammal()
        {
            MakeNoise();
            Move();
        }

    }
}
