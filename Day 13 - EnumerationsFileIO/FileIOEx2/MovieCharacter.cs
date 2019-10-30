using System;
using System.Collections.Generic;
using System.Text;

namespace FileIOEx2
{
    class MovieCharacter
    {
        public string Name { get; set; }
        public bool GoodBad { get; set; }
        public string Roll { get; set; }
        public int Age { get; set; }

        public MovieCharacter(string name, bool goodbad, string roll, int age)
        {
            Name = name;
            GoodBad = goodbad;
            Roll = roll;
            Age = age;
        }
    }
}
