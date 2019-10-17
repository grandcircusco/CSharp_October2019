using System;

namespace Day_2___Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Relational Operators

            bool result;
            int x = 10, y = 20;

            result = (x == y);
            Console.WriteLine($"Equal to Operator: {result}");

            result = (x > y);
            Console.WriteLine($"Greater than Operator: {result}");

            result = (x <= y);
            Console.WriteLine("Less than or equal to Operator: {0}", result);
            
            x+=11; //x = x(10) + 11;
            result = (x != y);
            Console.WriteLine("Not Equal to Operator: " + result);

            x--;
            result = (x != y);
            Console.WriteLine("Not Equal to Operator: " + result);
        }
    }
}
