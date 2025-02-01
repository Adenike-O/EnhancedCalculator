namespace AdvancedCalculator.Tests
{
    using Xunit;

    public class CalculatorTests
    {
        [Fact]
        public void TestAddition()
        {
            double result = Calculator.Add(2, 3); 
            Assert.Equal(5, result);
        }

        [Fact]
        public void TestSubtraction()
        {
            double result = Calculator.Subtract(5, 3); 
            Assert.Equal(2, result);
        }
    }

    // Dummy Calculator class 
    public static class Calculator
    {
        public static double Add(double a, double b) => a + b;
        public static double Subtract(double a, double b) => a - b;
    }
}
