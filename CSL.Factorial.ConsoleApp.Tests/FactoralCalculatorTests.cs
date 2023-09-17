namespace CSL.Factorial.ConsoleApp.Tests;

public class FactoralCalculatorTests
{
    [Theory]
    [InlineData(0, 1)]
    [InlineData(1, 1)]
    [InlineData(2, 2)]
    [InlineData(3, 6)]
    [InlineData(4, 24)]
    [InlineData(5, 120)]
    [InlineData(65, 9223372036854775808)]
    
    public void ShouldReturnCorrectResultForNumberInAcceptedRange(byte input, ulong expected)
    {
        var calculator = new FactorialCalculator();
        
        var result = calculator.Calculate(input);

        result.Should().Be(expected);
    }
    
    [Theory]
    [InlineData(66)]
    [InlineData(byte.MaxValue)]
    public void ShouldReturnArgumentExceptionForNumberOutsideExpectedRange(byte input)
    {
        var calculator = new FactorialCalculator();

        Assert.Throws<ArgumentOutOfRangeException>(() => calculator.Calculate(input));
    }
}