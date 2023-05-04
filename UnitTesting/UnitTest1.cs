using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTesting
{
    //Unit testing classes need to be set to public
    public class TestCalulator
    {
        [Fact]
        public void TestAdd()
        {
            //Arrange
            Calculator c = new Calculator();
            int expected = 3;

            //Act 
            int actual = c.Add(1, 2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,6,11)]
        [InlineData(5,5,10)]
        [InlineData(50,65,115)]
        public void TestAddTheory(int num1, int num2, int expected)
        {
            Calculator c = new Calculator();

            int actual = c.Add(num1, num2);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,6)]
        [InlineData(10,15)]
        [InlineData(10,60)]
        [InlineData(76,13)]
        [InlineData(123,14)]
        public void TestSubtract(int num1, int num2)
        {
            Calculator c = new Calculator();
            int expected = num1 - num2;
            int actual = c.Subtract(num1, num2);
            Assert.Equal(expected, actual);
        }
    }
}