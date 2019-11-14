using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_24___Core_Day_2.Models
{
    public class Supers
    {
        public string IRLName { get; set; }
        public string SuperName { get; set; }

        public bool GoodOrBad { get; set; }

        public int PowerLevel { get; set; }
        public string Universe { get; set; }
        public List<Power> Powers { get; set; }

        public Supers(string irlName, string superName, bool goodOrBad, string universe, List<Power> powers) 
        {
            IRLName = irlName;
            SuperName = superName;
            GoodOrBad = goodOrBad;
            Universe = universe;
            Powers = powers;
        }
    }
}
