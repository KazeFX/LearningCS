
namespace Packt.Shared;

public partial class Person : object
{

    #region Fields: Data or state for this person.

    public string? Name; // ? means it can be null.
    public DateTimeOffset Born;
    //public WondersOfTheAncientWorld FavoriteAncientWonder; Moved to PersonAutoGen
    public WondersOfTheAncientWorld BucketList;
    public List<Person> Children = new();

    public const string Species = "HUMAN";

    public readonly string HomePlanet = "Mars";
    public readonly DateTime Instantiated;

    #endregion

    #region Constructors: Called when using new to instantiate a type.

    public Person()
    {
        // Constructors can set default values for fields
        // including any read-only fields like Instantiated.
        Name = "Unknown";
        Instantiated = DateTime.Now;
    }

    public Person(string initialName, string homePlanet)
    {
        Name = initialName;
        HomePlanet = homePlanet;
        Instantiated = DateTime.Now;
    }

    #endregion

    #region Methods: Actions the type can perform.

    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {Born:dddd}.");
    }
    
    public string GetOrigin()
    {
        return $"{Name} was born on {HomePlanet}.";
    }

    public string SayHello()
    {
        return $"{Name} says 'Hello!'";
    }

    public string SayHello(string name)
    {
        return $"{Name} says 'Hello, {name}!'";
    }

    public string stabbyStab(string name) {
        return $"Sephiroth stabs {name}";
    }

    public string OptionalParameters(int count, string command = "Run!", double number = 0.0, bool active = true)
    {
        return string.Format(format: "command is {0}, number is {1}, active is {2}",
            arg0: command,
            arg1: number,
            arg2: active);
    }

    public void PassingParameters(int w, in int x, ref int y, out int z)
    {
        // out parameters cannot have a default and they must be initialized inside the method.
        z = 100;

        // Increment each parameter except the read-only x.
        w++;
        // x++; // Gives error
        y++;
        z++;

        WriteLine($"In the method: w={w}, x={x}, y={y}, z={z}");
    }

    public void ParamsParameters(string text, params int[] numbers)
    {
        int total = 0;

        foreach(int number in numbers)
        {
            total += number;
        }

        WriteLine($"{text}: {total}");
    }

    // Method that reutrns a tuple: (string, int)
    public (string, int) GetFruit()
    {
        return ("Apples", 5);
    }

    public (string Name, int Number) GetNamedFruit()
    {
        return (Name: "Apples", Number: 5);
    }

    // Deconstructors: Break down this object into parts

    public void Deconstruct(out string? name, out DateTimeOffset dob)
    {
        name = Name;
        dob = Born;
    }

    public void Deconstruct(out string? name, out DateTimeOffset dob, out WondersOfTheAncientWorld fav)
    {
        name = Name;
        dob = Born;
        fav = FavoriteAncientWonder;
    }

    // Method with a local function.
    public static int Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException($"{nameof(number)} cannot be less than zero.");
        }
        return localFactorial(number);
    }

    static int localFactorial(int localNumber) // Local function.
    {
        if (localNumber == 0) return 1;
        return localNumber * localFactorial(localNumber - 1);
    }
  


    #endregion
}