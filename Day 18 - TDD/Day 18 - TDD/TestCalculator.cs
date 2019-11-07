using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Day_18___TDD
{
    public class TestCalculator
    {
        [Fact]
        public void AddZeroAndZero()
        {
            int actual = Calculator.Addition(0, 0);
            Assert.Equal(0, actual);
        }

        [Fact]
        public void AddZeroAndOne()
        {
            int actual = Calculator.Addition(1, 0);
            Assert.Equal(1, actual);
        }

        [Fact]
        public void AddOneAndOne()
        {
            int actual = Calculator.Addition(1, 1);
            Assert.Equal(2, actual);
        }
    }
}
