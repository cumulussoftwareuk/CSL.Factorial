using CSL.Factorial.ConsoleApp;
using CSL.Factorial.ConsoleApp.Validators;

Console.WriteLine("Welcome to the factorial calculator.");

Console.WriteLine("Please enter a number and then press enter to calculate the factorial.");

var input = Console.ReadLine() ?? string.Empty;

var validationResult = new InputValidator().Validate(input);

if (validationResult.IsValid == false)
{
    var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage);
    Console.WriteLine(string.Join(Environment.NewLine, errorMessages));
}
else
{
    var convertedInput = byte.Parse(input);
    
    var calculator = new FactorialCalculator();

    var result = calculator.Calculate(convertedInput);

    Console.WriteLine($"The factorial is {result}");
}

Console.WriteLine("Press any key to finish.");
Console.ReadKey();