using Xunit;

namespace FalseTestingCoverage.Tests;

public class CalculatorTest
{
    [Fact]
    public void ItDividesNumeratorsWithDenominators()
    {
        int numerator = 4;
        int denominator = 2;

        double result = Calculator.divide(numerator, denominator);
        
        Assert.Equal(2, result);
    }
}

public class Calculator
{
    public static double divide(int numerator, int denominator)
    {
        return numerator / denominator;
    }
}