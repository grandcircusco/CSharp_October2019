using System;

namespace MockAssessment1d
{
    class Program
    {
        public static bool IsVowel(char c)
        {
            string vowels = "aeiou";

            foreach (char v in vowels)
            {
                if (v == c)
                {
                    return true;
                }
            }
            return false;
        }

        public static int CountVowels(string word)
        {
            int counter = 0;

            foreach (char c in word)
            {
                if (IsVowel(c) == true)
                {
                    counter++;
                }
            }

            return counter;
        }

        public static string TooManyVowels(string word)
        {
            int vowelCount = CountVowels(word);

            if(vowelCount <= 4)
            {
                return "few vowels";
            }
            else if (vowelCount >= 5 && vowelCount <= 8)
            {
                return "right amount of vowels";
            }
            else
            {
                return "too many vowels";
            }
        }
    }
}
