using System;
using System.Collections.Generic;
using System.IO;

namespace FileIOEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<MovieCharacter> characters = new List<MovieCharacter>()
            //{
            //    new MovieCharacter("Columbus", true, "Lead", 23),
            //    new MovieCharacter("Ruby Rose", true, "Lead", 17),
            //    new MovieCharacter("Jack Skellington", true, "Lead", 99),
            //    new MovieCharacter("Joker", false, "Lead", 30),
            //    new MovieCharacter("Doug \"The Thug\" Glatt", true, "Lead", 30),
            //    new MovieCharacter("John Rambo", true, "Lead", 75),
            //    new MovieCharacter("Lieutenant Dan", true, "Supporting Actor", 45),
            //    new MovieCharacter("Samwise Gamgee", true, "The Real MVP", 102)
            //};

            //StreamWriter writer = new StreamWriter("../../../MovieCharacters.txt");
            //foreach(MovieCharacter character in characters)
            //{
            //    writer.WriteLine($"{character.Name}|{character.GoodBad}|{character.Roll}|{character.Age}");
            //}
            //writer.Close();

            List<MovieCharacter> characters = new List<MovieCharacter>();
            StreamReader reader = new StreamReader("../../../MovieCharacters.txt");
            string line = reader.ReadLine();

            while (line != null)
            {
                string[] word = line.Split('|');
                characters.Add(new MovieCharacter(word[0], bool.Parse(word[1]), word[2], int.Parse(word[3])));
                line = reader.ReadLine();
            }
            reader.Close();

            foreach (MovieCharacter character in characters)
            {
                Console.WriteLine(character.Name);
            }
        }
    }
}
