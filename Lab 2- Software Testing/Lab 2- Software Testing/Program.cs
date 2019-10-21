using System;

namespace Lab_2__Software_Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Length: ");
                string input = Console.ReadLine();
                int length = int.Parse(input);

                Console.Write("Width: ");
                input = Console.ReadLine();
                int height = int.Parse(input);

                Console.Write("Height: ");
                input = Console.ReadLine();
                int width = int.Parse(input);

                Console.WriteLine($"Area: {length + length} + {width + width}");
                Console.WriteLine($"Perimeter: {length * height}");
                Console.WriteLine($"Volume: {(length * width * height)/3}");

                Console.WriteLine(Would you like to go again?);

                if(userContinue == false)
                {
                    continue;
                }
            }
        }
    }
}
