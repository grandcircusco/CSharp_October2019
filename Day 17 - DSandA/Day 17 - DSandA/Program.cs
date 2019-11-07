
    using System;

namespace Day_17___DSandA
{
    class Program
    {
        static void Main(string[] args)
        {
            MostAwesomeList awesomeList = new MostAwesomeList();
            awesomeList.Add("Bob Ross");
            Console.WriteLine(awesomeList.Count);

            awesomeList.Add("Mr. Rogers");
            Console.WriteLine(awesomeList.Count);

            awesomeList.Add("Steve Irwin");
            Console.WriteLine(awesomeList.Count);

            awesomeList.Add("Steve the TA");
            Console.WriteLine(awesomeList.Count);

            awesomeList.Add("Levar Burton");
            Console.WriteLine(awesomeList.Count);

            awesomeList.Add("Wishbone");
            Console.WriteLine(awesomeList.Count);

            awesomeList.RemoveAt(1);

            for (int i = 0; i < awesomeList.Count; i++)
            {
                Console.WriteLine(awesomeList.GetNode(i).Data);
            }
        }
    }
}
