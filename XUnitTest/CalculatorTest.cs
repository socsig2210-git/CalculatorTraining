using System;
using Xunit;
using FluentAssertions;
using System.Collections.Generic;
using FluentAssertions.Execution;

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
        public void FluentTest1()
        {
            string accountNumber = "1234567890";
            accountNumber.Should().Be("0987654321");
        }

        [Fact]
        public void FluentTest2()
        {
            var numbers = new[] { 1, 2, 3 };
            numbers.Should().Contain(item => item > 2, "at least {0} item should be larger than 3", 1);
        }

        [Fact]
        public void FluentTest3()
        {
            var actual = "ABCDEFGHI";
            actual.Should().StartWith("AB").And.EndWith("HI").And.Contain("EF").And.HaveLength(9);
        }
        
        [Fact]
        public void FluentTest4()
        {
            IEnumerable<int> numbers = new[] { 1, 2, 3 };

            numbers.Should().Contain(n => n > 0);
            numbers.Should().HaveCount(3, "because we thought we put {0} items in the collection", 3);
        }

        [Fact]
        public void FluentTest5()
        {
            using(new AssertionScope())
            {
                5.Should().Be(10);
                "Actual".Should().Be("Expected");
            }
        }

        [Fact]
        public void AddTest()
        {
            var calculator = new Calculator();
            var result = calculator.Add(26, 18);
            //TODO: Use FluentAssertions Library
            
            //Assert.Equal(44, result); 
            result.Should().Be(44);
        }

        [Fact]
        public void SubtractTest()
        {
            var calculator = new Calculator();
            var result = calculator.Subtract(153, 78);

            // Assert.Equal(75, result);
            result.Should().Be(75);
        }

        [Fact]
        public void MultiplyTest()
        {
            var calculator = new Calculator();
            var result = calculator.Multiply(24, 5);

            // Assert.Equal(120, result);
            result.Should().Be(120);
        }

        [Fact]
        public void DivideTest()
        {
            var calculator = new Calculator();
            var result = calculator.Divide(30, 6);

            // Assert.Equal(5, result);
            result.Should().Be(5);
        }
    }
}