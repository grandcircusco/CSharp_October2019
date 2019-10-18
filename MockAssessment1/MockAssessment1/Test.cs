using Xunit;

namespace MockAssessment1
{
    public class Test
    {
        [Theory]       
        [InlineData(34, 36)]
        [InlineData(7, 7)]
        [InlineData(99, 1000)]
        [InlineData(3, 3)]
        public void Test1(int num1, int num2)
        {
            bool actual = Program.IsTheSame(num1, num2);
            bool expected;

            if(num1 == num2)
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
        [InlineData(4.3, 78)]
        [InlineData(10,4)]
        public void Test2(double num1, double num2)
        {
            double actual = Program.Subtract(num1, num2);
            double expected = num1 - num2;

            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData(9)]
        [InlineData(2)]
        [InlineData(99)]
        [InlineData(37)]
        public void Test3(int num)
        {
            string actual = Program.FindBuildingType(num);
            string expected = "";
            if(num >= 4 && num <= 10)
            {
                expected = "This is an office building!";
            }
            else if (num > 50)
            {
                expected = "This is a SUPER skyscraper!";
            }
            else if (num >= 11 && num <= 49)
            {
                expected = "This is a skyscraper!";
            }
            else if( num < 3 )
            {
                expected = "This is a house!";
            }

            Assert.Equal(expected, actual);
        }
    }
}
