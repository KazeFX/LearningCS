using static System.Console;
namespace CheckingForOverflow;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            checked
            {
                int x = int.MaxValue - 1;
                WriteLine($"Initial value: {x}");
                x++;
                WriteLine($"After increment: {x}");
                x++;
                WriteLine($"After increment: {x}");
                x++;
                WriteLine($"After increment: {x}");
            }
        }
        catch (OverflowException)
        {
            WriteLine("The code overflowed but I caught the exception.");
        }

        unchecked
        {
            int y = int.MaxValue + 1;
            WriteLine($"Initial Vallue: {y}");
            y--;
            WriteLine($"After decrementing: {y}");
            y--;
            WriteLine($"After decrementing: {y}");
        }
    }
}