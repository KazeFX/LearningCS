using KazeLibrary;

internal partial class Program
{
    private static void Main(string[] args)
    {
        Person vader = new()
        {
            Name = "Vader",
            Born = new(year: 2005, month: 3, day: 25, hour: 0, minute: 0, second: 0, offset: TimeSpan.Zero)
        };

        //fahim.WriteToConsole();

        //// Implementing functionality using methods.
        //Person lamech = new() { Name = "Lamech" };
        //Person adah = new() { Name = "Adah" };
        //Person zillah = new() { Name = "Zillah" };

        //// Call the instance method to marry Isa and Jackbauer
        //lamech.Marry(adah);

        //// Call the static method to marry Jackbauer and Picard.
        //Person.Marry(lamech, zillah);

        //lamech.OutputSpouses();
        //adah.OutputSpouses();
        //zillah.OutputSpouses();

        //// Call the instance method to make a baby.
        //Person baby1 = lamech.ProCreateWith(adah);
        //baby1.Name = "Jabal";
        //WriteLine($"{baby1.Name} was born on {baby1.Born}");

        //// Call the static method to make a baby
        //Person baby2 = Person.Procreate(zillah, lamech);
        //baby2.Name = "Tubalcain";

        //// Use the * operator to "multiply".
        //Person baby3 = lamech * adah;
        //baby3.Name = "Jubal";

        //Person baby4 = zillah * lamech;
        //baby4.Name = "Naamah";

        //adah.WriteChildrenToConsole();
        //zillah.WriteChildrenToConsole();
        //lamech.WriteChildrenToConsole();

        //for (int i = 0; i < lamech.Children.Count; i++)
        //{
        //    WriteLine(format: "     {0}'s child #{1} is named \"{2}\".",
        //        arg0: lamech.Name, arg1: i, arg2: lamech.Children[i].Name);
        //}

        //// Person.Marry(lamech, zillah)

        //if (lamech + zillah)
        //{
        //    WriteLine($"{lamech.Name} and {zillah.Name} successfully got married.");
        //}

        // Non-generic lookup collection
        System.Collections.Hashtable lookupObject = new();
        lookupObject.Add(key: 1, value: "Alpha");
        lookupObject.Add(key: 2, value: "Beta");
        lookupObject.Add(key: 3, value: "Gamma");
        lookupObject.Add(key: vader, value: "Delta");

        int key = 2; // Look up the value that has 2 as its key.

        WriteLine(format: "Key {0} has value: {1}",
            arg0: key,
            arg1: lookupObject[key]);

        WriteLine(format: "Key {0} has value: {1}",
            arg0: vader,
            arg1: lookupObject[vader]);

        // Define a generic lookup collection.
        Dictionary<int, string> lookupIntString = new();
        lookupIntString.Add(key: 1, value: "Alpha");
        lookupIntString.Add(key: 2, value: "Beta");
        lookupIntString.Add(key: 3, value: "Gamma");
        lookupIntString.Add(key: 4, value: "Delta");

        key = 3;

        WriteLine(format: "Key {0} has value: {1}",
            arg0: key,
            arg1: lookupIntString[key]);

        // Assign the method to the Shout delegate.
        vader.Shout += Vader_Shout;
        vader.Shout += Vader_Shout_2;

        // Call the Poke method that evnetually raises the Shout event.
        vader.Poke();
        vader.Poke();
        vader.Poke();
        vader.Poke();

        Person?[] people =
        {
            null,
            new() { Name = "Darth Vader"},
            new() { Name = "Nemesis"},
            new() { Name = "Sadako"},
            new() { Name = null},
            new() { Name = "Vecna"}
        };

        OutputPeopleNames(people, "Initial list of people:");

        Array.Sort(people);

        OutputPeopleNames(people, "After sorting using Person's IComparable implementation:");

        Array.Sort(people, new PersonComparer());

        OutputPeopleNames(people, "After sorting using PersonComparer's IComparer implementation:");

        Employee kevin = new()
        {
            Name = "Kevin",
            Born = new(year: 1979, month: 3, day: 3,
            hour: 0, minute: 0, second: 0, offset: TimeSpan.Zero)
        };

        kevin.WriteToConsole();
        kevin.EmployeeCode = "T1000";
        kevin.HireDate = new(year: 1997, month: 8, day: 29);
        WriteLine($"{kevin.Name} was hired on {kevin.HireDate:yyyy-MM-dd}.");
        WriteLine(kevin.ToString());

        Employee aliceInEmployee = new() { Name = "Alice", EmployeeCode = "AA123" };
        Person aliceInPerson = aliceInEmployee;
        aliceInEmployee.WriteToConsole();
        aliceInPerson.WriteToConsole();
        WriteLine(aliceInEmployee.ToString());
        WriteLine(aliceInPerson.ToString());

        if (aliceInPerson is Employee)
        {
            WriteLine($"{nameof(aliceInPerson)} is an Employee.");

            Employee explicitAlice = (Employee)aliceInPerson;

            // Safe to manipulate explicitAlice.
        }

        Employee? aliceAsEmployee = aliceInPerson as Employee;

        if (aliceAsEmployee is not null)
        {
            WriteLine($"{nameof(aliceInPerson)} as an Employee.");

            // safe to manipulate alice.
        }

        try
        {
            kevin.TimeTravel(when: new(1999, 12, 31));
            kevin.TimeTravel(when: new(1950, 12, 25));
        }
        catch (PersonException ex)
        {
            WriteLine(ex.Message);
        }


        string email1 = "darthvader@empire.com";
        string email2 = "yoda%jedi.com";

        WriteLine("{0} is a valid e-mail address: {1}",
            arg0: email1,
            arg1: StringExtensions.IsValidEmail(email1));

        WriteLine("{0} is a valid e-mail address: {1}",
            arg0: email2,
            arg1: StringExtensions.IsValidEmail(email2));

        WriteLine("{0} is a valid e-mail address: {1}",
            arg0: email1,
            arg1: email1.IsValidEmail());

        WriteLine("{0} is a valid e-mail address: {1}",
            arg0: email2,
            arg1: email2.IsValidEmail());

    }
}