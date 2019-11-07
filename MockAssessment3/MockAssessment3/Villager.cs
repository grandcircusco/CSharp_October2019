using System;
using System.Collections.Generic;
using System.Text;

namespace MockAssessment3
{
    abstract class Villager
    {
        public int Hunger { get; set; }

        public abstract int Farm();
    }
}
