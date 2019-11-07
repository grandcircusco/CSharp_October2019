using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FizzBuzzWoof
{
    public class TestFizzBuzzWoof
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "Fizz")]
        [InlineData(4, "4")]
        [InlineData(5, "Buzz")]
        [InlineData(6, "Fizz")]
        [InlineData(7, "Wolf")]
        [InlineData(8, "8")]
        [InlineData(9, "Fizz")]
        [InlineData(10, "Buzz")]
        [InlineData(11, "11")]
        [InlineData(12,"Fizz")]
        [InlineData(13, "Fizz")]
        [InlineData(14, "Wolf")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(16, "16")]
        [InlineData(17, "Wolf")]
        [InlineData(18, "Fizz")]
        [InlineData(19, "19")]
        [InlineData(20, "Buzz")]
        [InlineData(21, "FizzWolf")]
        [InlineData(22, "22")]
        [InlineData(23, "Fizz")]
        [InlineData(24, "Fizz")]
        [InlineData(25, "Buzz")]
        [InlineData(26, "26")]
        [InlineData(27, "FizzWolf")]
        [InlineData(28, "Wolf")]
        [InlineData(29,"29")]
        [InlineData(30,"FizzBuzz")]
        [InlineData(31,"Fizz")]
        [InlineData(32,"Fizz")]
        [InlineData(33,"Fizz")]
        [InlineData(34,"Fizz")]
        [InlineData(35,"FizzBuzzWolf")]
        [InlineData(36, "Fizz")]
        [InlineData(37, "FizzWolf")]
        [InlineData(38, "Fizz")]
        [InlineData(39, "Fizz")]
        [InlineData(40, "Buzz")]
        [InlineData(41, "41")]
        [InlineData(42, "FizzWolf")]
        [InlineData(43, "Fizz")]
        [InlineData(44, "44")]
        [InlineData(45, "FizzBuzz")]
        [InlineData(46, "46")]
        [InlineData(47, "Wolf")]

        public void FBWTest(int number, string expected)
        {
            string actual = FizzBuzzWoof.FBW(number);
            Assert.Equal(expected, actual);
        }
    }
}
