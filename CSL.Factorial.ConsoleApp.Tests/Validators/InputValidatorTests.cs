using CSL.Factorial.ConsoleApp.Validators;

namespace CSL.Factorial.ConsoleApp.Tests.Validators;

public class InputValidatorTests
{
    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(65)]
    public void WholeNumberBetween0And65ShouldBeValid(int input)
    {
        var validator = new InputValidator();

        var result = validator.Validate(input.ToString());

        result.IsValid.Should().BeTrue();
    }
    
    [Theory]
    [InlineData(-1)]
    [InlineData(66)]
    [InlineData(int.MaxValue)]
    public void NumberOutside0And65ShouldNotBeValid(decimal input)
    {
        var validator = new InputValidator();

        var result = validator.Validate($"{input}");

        result.IsValid.Should().BeFalse();
    }
    
    [Theory]
    [InlineData(0.1)]
    [InlineData(65.1)]
    public void DecimalNumberShouldNotBeValid(decimal input)
    {
        var validator = new InputValidator();

        var result = validator.Validate($"{input}");

        result.IsValid.Should().BeFalse();
    }
    
    [Theory]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("Test1")]
    public void NonNumericalInputShouldNotBeValid(string input)
    {
        var validator = new InputValidator();

        var result = validator.Validate(input);

        result.IsValid.Should().BeFalse();
    }
}