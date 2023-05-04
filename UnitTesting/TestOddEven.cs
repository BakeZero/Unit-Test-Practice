using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTesting
{
    public class TestOddEven
    {
        [Theory]
        [InlineData(7, "PRIME")]
        [InlineData(24, "EVEN")]
        [InlineData(25, "ODD")]
        [InlineData(83, "PRIME")]
        public void TestDoOddEven(int num, string expected)
        {
            OddEven oddEven = new OddEven();
            string actual = oddEven.DoOddEven(num);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(12, false)]
        [InlineData(17, true)]
        public void TestIsPrime(int num, bool expected)
        {
            OddEven oddEven = new OddEven();
            bool actual = oddEven.IsPrime(num);
            Assert.Equal(expected, actual);
        }
    }
}
