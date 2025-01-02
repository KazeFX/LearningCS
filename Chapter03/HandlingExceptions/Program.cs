namespace HandlingExceptions;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        WriteLine("Before parsing.");
        Write("What is your age? ");
        /*string? input = ReadLine();

        try
        {
            int age = int.Parse(input);
            WriteLine($"You are {age} years old.");
        }
        catch (OverflowException)
        {
            WriteLine($"Your age is a valid number format but it is either too big or too small.");
        }
        catch (FormatException)
        {
            WriteLine("The age you entered is not a valid number format.");
        }
        catch (Exception ex)
        {
            WriteLine($"{ex.GetType()} says {ex.Message}");
        }
        WriteLine("After parsing.");*/

        Write("Enter amount: ");
        string? input = ReadLine();

        try
        {
            decimal amountValue = decimal.Parse(input);
        }
        catch (FormatException) when (input.Contains("$"))
        {
            WriteLine("Can't have no dollar bills in amount!");
        }
        catch (FormatException)
        {
            WriteLine("Amount must only contain numbers!");
        }
    }
}