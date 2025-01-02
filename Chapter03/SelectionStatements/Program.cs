using static System.Console;
namespace SelectionStatements;

class Program
{
    static void Main(string[] args)
    {
        string password = "ninja";

        // dont do if without brackets, even if it works
        if (password.Length < 8)
            WriteLine("Password too short");
        else
            WriteLine("Password OK");

        object o = "3";
        int j = 4;

        if (o is int i)
        {
            WriteLine($"{i} x {j} = {i * j}");
        }
        else
        {
            WriteLine("o is not an int");
        }

        int number = (new Random()).Next(1, 7);
        WriteLine($"Your number is {number}");

        switch (number)
        {
            case 1:
                WriteLine("One");
                break;
            case 2:
                WriteLine("Two");
                goto case 1;
            case 3: // multiple case section
            case 4:
                WriteLine("Three or four");
                goto case 1;
            case 5:
                goto A_label;
            default:
                WriteLine("Default");
                break;
        }

        WriteLine("After end of switch");
    A_label:
        WriteLine("After A_label");

        // string path = "/Users/kazefx/Code";
        string path = @"/Users/kazefx/Code/CS/LearningCS/Chapter03";

        Write("Press R for read-only or W for writeable: ");
        ConsoleKeyInfo key = ReadKey();
        WriteLine();

        Stream? s;

        if (key.Key == ConsoleKey.R)
        {
            s = File.Open(
                Path.Combine(path, "file.txt"),
                FileMode.OpenOrCreate,
                FileAccess.Write);
        }
        else
        {
            s = File.Open(
                Path.Combine(path, "file.txt"),
                FileMode.OpenOrCreate,
                FileAccess.Write);
        }

        string message;

        switch (s)
        {
            case FileStream writeableFile when s.CanWrite:
                message = "Writeable file";
                break;
            case FileStream readOnlyFile:
                message = "Read-only file";
                break;
            case MemoryStream ms:
                message = "Memory stream";
                break;
            default: // always evaluated last despite its current position
                message = "Unknown stream";
                break;
            case null:
                message = "Null stream";
                break;
        }
        WriteLine(message);

        message = s switch
        {
            FileStream writeableFile when s.CanWrite
                => "Writeable file",
            FileStream readOnlyFile
                => "Read-only file",
            MemoryStream ms
                => "Memory stream",
            null => "Null stream",
            _ => "Unknown stream"
        };

    }
}