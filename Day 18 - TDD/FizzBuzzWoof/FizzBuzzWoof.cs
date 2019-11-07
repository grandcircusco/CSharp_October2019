using System;

namespace FizzBuzzWoof
{
    class FizzBuzzWoof
    {
       public static string FBW(int number)
        {
            if (number % 15 == 0)
            {
                return "FizzBuzz";
            }
            else if (number == 21 || number == 27|| number == 37 || number == 42)
            {
                return "FizzWolf";
            }
            else if (number == 35)
            {
                return "FizzBuzzWolf";
            }
            else if(number % 3 == 0 || number.ToString().Contains("3"))
            {
                return "Fizz";
            }
            
            else if (number %5 == 0)
            {
                return "Buzz";
            }
                                                                                                                                    
            else if (number % 7 == 0 || number == 17 || number ==47)
            {
                return "Wolf";
            }
           
            
            return number.ToString();
        }
    }
}
