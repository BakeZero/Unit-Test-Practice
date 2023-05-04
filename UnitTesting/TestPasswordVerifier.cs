using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class TestPasswordVerifier
    {
        [Theory]
        [InlineData("123457", false)]
        [InlineData("", false)]
        [InlineData("abcdefgh", false)]
        [InlineData("ABCDEFGH", false)]
        [InlineData("AbCdEfGh", false)]
        [InlineData("abcd56aH", true)]
        public void TestVerify(string pass, bool expected)
        {
            PasswordVerifier pv = new PasswordVerifier();
            bool actual = pv.Verify(pass);
            Assert.Equal(actual, expected);
        }
    }
}
