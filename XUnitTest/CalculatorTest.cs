using System;
using Xunit;

namespace XUnitTest
{
    public class CalculatorTest
    {
        //[Fact]
        //public void PassingTest()
        //{
        //    Assert.Equal(4, Add(2, 2));
        //}

        //[Fact]
        //public void FailingTest()
        //{
        //    Assert.Equal(5, Add(2, 2));
        //}

        //int Add(int x, int y)
        //{
        //    return x + y;
        //}

        //[Theory]
        //[InlineData(3)]
        //[InlineData(4)]
        //[InlineData(5)]
        //public void MyFirstTheory(int value)
        //{
        //    Assert.True(IsOdd(value));
        //}

        //bool IsOdd(int value)
        //{
        //    return value % 2 == 1;
        //}

        [Fact]
        public void AddTest()
        {
            var calculator = new Calculator();
            var result = calculator.Add(26, 18);
            Assert.Equal(44, result);
        }

        [Fact]
        public void SubtractTest()
        {
            var calculator = new Calculator();
            var result = calculator.Subtract(153, 78);
            Assert.Equal(75, result);
        }

        [Fact]
        public void MultiplyTest()
        {
            var calculator = new Calculator();
            var result = calculator.Multiply(24, 5);
            Assert.Equal(120, result);
        }

        [Fact]
        public void DivideTest()
        {
            var calculator = new Calculator();
            var result = calculator.Divide(30, 6);
            Assert.Equal(5, result);
        }
    }
}