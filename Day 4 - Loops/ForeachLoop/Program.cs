using System;

namespace ForeachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int aCount = CountLetter("Ali Ababwa");
            Console.WriteLine("Expected: 4, Actual: " + aCount);

            int letterCount = CountLetter("Babbabouie", 'b');
            Console.WriteLine("Expected: 4, Actual: " + letterCount);
        }

        public static int CountLetter(string word)
        {
            int count = 0;
            foreach(char letter in word.ToLower())
            {
                if(letter == 'a')
                {
                    count = count + 1;
                }
            }
            return count;
        }

        public static int CountLetter(string word, char findLetter)
        {
            int count = 0;
            foreach(char letter in word.ToLower())
            {
                if(letter == findLetter)
                {
                    count++;
                }
            }
            return count;
        }

    }
}
