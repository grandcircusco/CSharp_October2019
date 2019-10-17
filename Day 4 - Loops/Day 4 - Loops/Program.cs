using System;

namespace Day_4___Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello(3);
        }

        public static void SayHello(int number)
        {
            while (true)
            {
                Console.WriteLine("Hello while true");
                number--;
                if(number == 0)
                {
                    break;
                }
            }
        }
    }
}
