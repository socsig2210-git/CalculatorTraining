using Xunit;

namespace XUnitTest
{
    public  class CalculatorTestTheory
    {
        [Theory]
        [InlineData(-20, 15.8)]
        [InlineData(18, 56)]
        [InlineData(-13.5, -1.5)]
        [InlineData(156, 0)]
        [InlineData(14.23, 12.37)]
        public void AddTestTheory(float x, float y)
        {
            var calculator = new Calculator();
            var result = calculator.Add(x, y);
            Assert.Equal(x + y, result);
        }

        [Theory]
        [InlineData(-20, 15.8)]
        [InlineData(18, 56)]
        [InlineData(-13.5, -1.5)]
        [InlineData(156, 0)]
        [InlineData(14.23, 12.37)]
        public void SubtractTestTheory(float x, float y)
        {
            var calculator = new Calculator();
            var result = calculator.Subtract(x, y);
            Assert.Equal(x - y, result);
        }

        [Theory]
        [InlineData(-20, 15.8)]
        [InlineData(18, 56)]
        [InlineData(-13.5, -1.5)]
        [InlineData(156, 0)]
        [InlineData(14.23, 12.37)]
        public void MultiplyTestTheory(float x, float y)
        {
            var calculator = new Calculator();
            var result = calculator.Multiply(x, y);
            Assert.Equal(x * y, result);
        }

        [Theory]
        [InlineData(-20, 15.8)]
        [InlineData(18, 56)]
        [InlineData(-13.5, -1.5)]
        [InlineData(156, 0)]
        [InlineData(14.23, 12.37)]
        public void DivideTestTheory(float x, float y)
        {
            var calculator = new Calculator();
            var result = calculator.Divide(x, y);
            var expected = x / y;
            if (expected != float.PositiveInfinity && expected != float.NegativeInfinity)
                Assert.Equal(expected, result);
            else
                Assert.False(true);
        }


    }
}
