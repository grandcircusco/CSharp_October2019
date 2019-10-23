using System;

namespace ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tvArray = { "Game of Thrones", "Walking Dead", "Barry", "Southpark", "Futurama", "Samurai Jack" };

            //This is creating a reference to tvArray called tvShowArray
            string[] tvShowArray = tvArray;
            //Any changes to tvArray will also affect the tvShowArray

            tvShowArray[3] = "Breaking Bad";
            Console.WriteLine(tvArray[3]);

            string[] copyTvArray = new string[tvArray.Length];
            tvArray.CopyTo(copyTvArray, 0);

            copyTvArray[5] = "Parks and Rec";

            for (int i = 0; i < tvArray.Length; i++)
            {
                Console.WriteLine($"tvArray[{i}]: {tvArray[i]}, \t \t copyTvArray[{i}]: {copyTvArray[i]}");
            }
        }
    }
}


//WHITEBOARD
//Create an array of three colors (red, green, blue)
//Print out the third color
//Print out the length of the array
//Add a line of code to change green to white

//use a foreach loop to print all three colors
//use a for-loop to print all three colors backwards

//PAIR PROGRAM
/*
1. Create a string array of names
2. Sort the names into alphabetical order (there's an app...er.. method.. for that!)
3. Sort the names into alphabetical order (i.e. "Anna" would become "Aann")
4. Print the arrays side-by-side
*/