using System;

namespace TryCatchEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            try //if
            {
                Console.Write("Please enter a number: ");
                int input1 = int.Parse(Console.ReadLine());

                Console.Write("Please enter another number: ");
                int input2 = int.Parse(Console.ReadLine());

                int result = input1 / input2;

                Console.WriteLine(result);
            }
            catch(FormatException) //else if
            {
                Console.WriteLine("Bad input. We need a number.");
            }
            catch (DivideByZeroException)//else if
            {
                Console.WriteLine("Can't divide by zero."); 
            }
            catch (OverflowException) //else if
            {
                Console.WriteLine("That number is toooo big.");
            }
            catch //else
            {
                throw new Exception("Something went wrong");
            }
        }
    }
}
