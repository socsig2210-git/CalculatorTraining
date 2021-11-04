using CalculatorTraining;
using Moq;
using Xunit;
using FluentAssertions;

namespace XUnitTest
{
    public class FinanceTest
    {
        //TODO: Test CustomAction by mocking ICalculator with Moq Library 

        [Fact]
        public void CustomActionNormalCalculatorTest()
        {
            // Setup
            var x = 3;
            var y = 4;

            var calculatorMock = new Mock<ICalculator>();
            calculatorMock.Setup(c => c.Add(
                It.IsAny<float>(),
                It.IsAny<float>()
                )).Returns(x*x + y*y);
            var finance= new Finance(calculatorMock.Object);

            // Arrange
            var expected = 35;

            // Act
            var actual = finance.CustomAction(x, y);

            // Assert
            actual.Should().Be(expected);
        }

        [Fact]
        public void CustomActionCrazyCalculator()
        {
            // Setup
            var x = 3;
            var y = 4;

            var calculatorMock = new Mock<ICalculator>();
            calculatorMock.Setup(c => c.Add(
                It.IsAny<float>(),
                It.IsAny<float>()
                )).Returns(x*x + y*y + 2);
            var finance = new Finance(calculatorMock.Object);

            // Arrange
            var expected = 37;

            // Act
            var actual = finance.CustomAction(x, y);

            // Assert
            actual.Should().Be(expected);
        }
    }
}