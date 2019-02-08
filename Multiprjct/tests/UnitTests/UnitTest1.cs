using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Add_WorksWithTwoPositiveIntegers()
        {
            var expected = 0;
            var a = 2;
            var b = 2;
            var actual = Mod(a, b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Add_WorksWithTwoNegativeIntegers()
        {
            var expected = -1;
            var a = -5;
            var b = -2;
            var actual = Mod(a, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(9)]
        public void IsOdd_WorksWithManyInputs(int value)
        {
            Assert.True(IsOdd(value));
        }


        [Theory]
        [InlineData(0, 2, 2)]
        [InlineData(-2, -7, -5)]
        [InlineData(0, 2, -2)]
        public void Add_WorksWithManyInputs(int exp, int n1, int n2)
        {
            Assert.Equal(exp, Mod(n1, n2));
        }



        // for more see https://xunit.github.io/docs/getting-started/netcore/cmdline

        int Mod(int x, int y)
        {
            return x % y;
        }

        bool IsOdd(int value)
        {
            return value % 2 == 1;
        }
    }
}
