using static System.Console;
namespace IterationStatements;

class Program
{
    static void Main(string[] args)
    {
        /*
        int x = 0;

        while (x < 10)
        {
            WriteLine(x);
            x++;
        }

        string? password;
        int count = 10;
        
        /*
        do
        {
            Write("Enter your password: ");
            password = ReadLine();
            count--;
        } while (password != "jabba" && count > 0);

        if (count == 0)
        {
            WriteLine("Too many attempts.");
        }
        else
        {
            WriteLine("Correct!");
        }
        */

        for (int y = 1; y <= 10; y++)
        {
            WriteLine(y);
        }

        string[] names = { "Adam", "Bary", "Chalie" };

        foreach (string name in names)
        {
            WriteLine($"{name} has {name.Length} characters.");
        }
    }
}