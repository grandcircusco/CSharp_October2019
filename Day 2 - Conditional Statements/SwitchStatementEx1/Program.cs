using System;

namespace SwitchStatementEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            Console.WriteLine("Give me an animal: Cat, dog, or elephant");
            string userInput = Console.ReadLine();
            
            userInput = userInput.ToLower();
            string sound;

            switch (userInput)
            {
                case "cat":
                    //Whatever you want to happen
                    sound = "meow";
                    break;
                case "dog":
                    sound = "woof";
                    break;
                case "elephant":
                    sound = "bahruuuuuuhhhhaaaaa";
                    break;
                default:
                    sound = "what?";
                    break;
            }

            Console.WriteLine($"A {userInput} sounds like {sound}");
        }
    }
}
