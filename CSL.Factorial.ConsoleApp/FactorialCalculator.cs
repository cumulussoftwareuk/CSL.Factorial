namespace CSL.Factorial.ConsoleApp;

public class FactorialCalculator
{
    private const byte MaxInput = 65;
    
    public ulong Calculate(byte input)
    {
        CheckInputIsInSupportedRange(input);
        
        var result = PerformCalculation(input);

        return result;
    }

    private static ulong PerformCalculation(byte input)
    {
        ulong result = 1;
        
        for (byte i = 1; i <= input; i++)
        {
            result *= i;
        }

        return result;
    }

    private static void CheckInputIsInSupportedRange(byte input)
    {
        if (input > MaxInput)
        {
            throw new ArgumentOutOfRangeException(nameof(input), "Input must be between 0 and 65");
        }
    }
}