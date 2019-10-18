using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MockAssessment1d
{
    public class Test
    {
        [Theory]
        [InlineData('a')]
        [InlineData('s')]
        [InlineData('z')]
        [InlineData('e')]
        [InlineData('w')]

        public void Test1(char c)
        {
            string vowels = "aeiou";

            bool actual = Program.IsVowel(c);
            bool expected = false;

            if (vowels.Contains(c))
            {
                expected = true;
            }
            else
            {
                expected = false;
            }


            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("words")]
        [InlineData("are")]
        [InlineData("difficult")]
        [InlineData("robots")]

        public void Test2(string word)
        {
           string vowels = "aeiuo";
            int actual = Program.CountVowels(word);
            int expected = 0;

            foreach (char c in word)
            {
                if(vowels.Contains(c))
                {
                    expected++;
                }
            }

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("words are difficult to understand")]
        [InlineData("some kind of robot?")]
        [InlineData("humpty dumpty")]
        [InlineData("sat on a wall")]
        public void Test3(string word)
        {
            string vowels = "aeiuo";
            int vowelCount = 0;
            string expected = "";
            string actual = Program.TooManyVowels(word);

            foreach (char c in word)
            {
                if (vowels.Contains(c))
                {
                    vowelCount++;
                }
            }

            if (vowelCount <= 4)
            {
                expected = "few vowels";
            }
            else if (vowelCount >= 5 && vowelCount <= 7)
            {
                expected = "right amount of vowels";
            }
            else if (vowelCount >= 8)
            {
                expected = "too many vowels";
            }

            Assert.Equal(expected, actual);
        }
    }
}
