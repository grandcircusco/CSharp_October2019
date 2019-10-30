using System;
using System.Collections.Generic;
using System.IO;

namespace FileIOExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            StreamReader reader = new StreamReader("../../../Students.txt");
            string line = reader.ReadLine();
            while(line != null)
            {
                names.Add(line);
                line = reader.ReadLine();
            }
            reader.Close();

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            names.Add("Harry Potter");

            StreamWriter writer = new StreamWriter("../../../Students.txt");
            foreach(string name in names)
            {
                writer.WriteLine(name);
            }
            writer.Close();
        }
    }
}
