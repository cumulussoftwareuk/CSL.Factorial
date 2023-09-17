using System.Diagnostics;
using FluentValidation;

namespace CSL.Factorial.ConsoleApp.Validators;

public class InputValidator: AbstractValidator<string>
{
    private const byte MaxInput = 65;
    public InputValidator()
    {
        const string emptyErrorMessage = "Input cannot be empty";
        const string invalidErrorMessage = "Input must be a whole number between 0 and 65";
        
        RuleFor(input => input)
            .NotEmpty()
            .WithMessage(emptyErrorMessage)
            .Must(input =>
            {
                var success = byte.TryParse(input, out var parsedInput);
                Debug.WriteLine(parsedInput);
                return success && parsedInput <= MaxInput;
            })
            .WithMessage(invalidErrorMessage);
    }
}