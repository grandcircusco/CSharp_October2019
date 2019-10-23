using System;
using System.Collections.Generic;

namespace StarWarsDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, bool> starWarsCharacters = new Dictionary<string, bool>
            {
                { "Anakin Skywalker", true },
                {"Obi Wan Kenobi", true },
                {"Frodo", false  },
                { "Darth Maul", true},
                { "R2D2", false},
                { "Captain Picard", false},
                { "Yoda", true}
            };

            starWarsCharacters.Add("Han Solo", false);

            foreach(KeyValuePair<string, bool> kvp in starWarsCharacters)
            {
                PrintCharacters(kvp);
            }
        }
        public static void PrintCharacters(KeyValuePair<string, bool> character)
        {
            if (character.Value == true)
            {
                Console.WriteLine($"{character.Key} has the force");
            }
            else
            {
                Console.WriteLine($"{character.Key} does not have the force.");
            }
        }

    }
}
