using CallStackExceptionHandlingLib;
using static System.Console;

namespace CallStackExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("In Main");
            Alpha();
        }

        static void Alpha()
        {
            WriteLine("In Alpha");
            Beta();
        }

        static void Beta()
        {
            WriteLine("In Beta");
            try
            {
                Calculator.Gamma();
            }
            catch (Exception ex)
            {
                WriteLine($"Caught this: {ex.Message}");
                throw;
            }
        }
    }
}