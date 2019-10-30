using System;

namespace Day_9___Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating an object of MyClass using the default constructor
            MyClass classDefault = new MyClass();
            Console.WriteLine(classDefault.MyProperty);

            classDefault.MyProperty = "C#";
            Console.WriteLine(classDefault.MyProperty);

            //Creating an object of MyClass using the overloaded constructor
            MyClass classOverload = new MyClass("C# October 2019");
            Console.WriteLine(classOverload.MyProperty);
        }
    }
}
