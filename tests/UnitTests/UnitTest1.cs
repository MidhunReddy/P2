using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Addition_WithTwoInts()
        {
            var expected = 10;
            var a = 8;
            var b = 2;
            var actual = Addition(a, b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Addition_WithTwoNegativeInts()
        {
            var expected = -15;
            var a = -9;
            var b = -6;
            var actual = Addition(a, b);
            Assert.Equal(expected, actual);
        }




        [Theory]
        [InlineData(3, 3, 6)]
        [InlineData(-6, -2, -8)]
        [InlineData(-8, 2, -6)]
        public void Addition_WithDifferentInputs(int n1, int n2, int value)
        {
            Assert.Equal(Addition(n1, n2), value);
        }



        int Addition(int x, int y)
        {
            return x + y;
        }


    }
}