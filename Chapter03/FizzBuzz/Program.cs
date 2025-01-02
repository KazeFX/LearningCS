namespace FizzBuzz;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Write(1);
        for (int i = 2; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                Write(", Fizz");
            }
            else if (i % 5 == 0)
            {
                Write(", Buzz");
            }
            else
            {
                Write($", {i}");
            }
        }
    }
}