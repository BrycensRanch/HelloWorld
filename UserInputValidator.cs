using System.ComponentModel.DataAnnotations;

namespace HelloWorld;

public class UserInputValidator
{
    public int Validate(string? input)
    {
        
// Basic user input validation
        if (input == null)
        {
            throw new ValidationException($"result cannot be null. Got: '{input}'");
        }

        try
        {
            return int.Parse(input);
        }
        catch (FormatException)
        {
            throw new ValidationException($"Unable to parse '{input}'");
        }
    }
}