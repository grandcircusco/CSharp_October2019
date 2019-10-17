using System;

namespace Day_4___Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string together = string.Concat("This is the first part, ", "this is the second part.");
            Console.WriteLine(together);

            bool isEqual = together.Equals("This is not a string");
            Console.WriteLine($"{together} equals \"This is not a string\": {isEqual}");

            int isSame = string.Compare("Cat", "Dog");
            Console.WriteLine($"Cat == Dog: " + isSame);

            isSame = string.Compare("Dog", "Cat");
            Console.WriteLine($"Dog == Cat: " + isSame);

            int index = together.IndexOf("is");
            Console.WriteLine($"Expected: 2, Actual {index}");

            index = together.LastIndexOf("is");
            Console.WriteLine($"Expected: 30ish, Actual {index}");

            bool endsWith = together.EndsWith('!');
            Console.WriteLine($"Expected: false, Actual {endsWith}");

            string newTogether = together.ToLower().Replace("this", "");
            Console.WriteLine(newTogether);

            string[] togetherArray = together.Split();
            foreach(string word in togetherArray)
            {
                Console.WriteLine(word);
            }

            index = together.LastIndexOf("this");

            string togetherPartTwo = together.Substring(index);
            Console.WriteLine(togetherPartTwo);

            string shorterTogetherPartTwo = together.Substring(index, 4);
            Console.WriteLine(shorterTogetherPartTwo);

            string beginningTogether = together.Substring(0, index);
            Console.WriteLine(beginningTogether);
        }
    }
}
