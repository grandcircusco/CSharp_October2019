using System;
using System.Collections.Generic;

namespace ListsExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> movies = new List<string>();
            movies.Add("Pulp Fiction");
            movies.Add("Midsommer");
            movies.Add("Braveheart");
            movies.Add("Nightmare Before Christmas");
            movies.Add("It's a Wonderful Life");

            for(int i = 0; i < movies.Count; i++)
            {
                Console.WriteLine($"{i+1}. {movies[i]}");
            }
        }
    }
}
