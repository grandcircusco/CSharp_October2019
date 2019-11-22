using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_30___WebAPIs.Models
{

    public class Chuck
    {
        public string type { get; set; }
        public Value value { get; set; }
    }

    public class Value
    {
        public int id { get; set; }
        public string joke { get; set; }
        public object[] categories { get; set; }
    }

}
