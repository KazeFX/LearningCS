using Microsoft.Win32.SafeHandles;
using Packt.Shared;
using System.Net.NetworkInformation;
using static System.Console;

namespace PeopleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Person anakin = new() { Name = "Anakin" };
            Person padme = new() { Name = "Padme" };
            Person amanda = new() { Name = "Amanda" };

            // call instance method
            Person baby1 = padme.ProcreateWith(anakin);
            baby1.Name = "Obi-Wan";

            // call static method    
            Person baby2 = Person.Procreate(anakin, padme);

            // call an operator
            Person baby3 = anakin * padme;

            Person rathalos = new();

            WriteLine($"{anakin.Name} has {anakin.Children.Count} children.");
            WriteLine($"{amanda.Name} has {amanda.Children.Count} children.");
            WriteLine($"{padme.Name} has {padme.Children.Count} children.");
            WriteLine(format: "{0}'s first child is named \"{1}\".",
                arg0: anakin.Name,
                arg1: anakin.Children[0].Name);

            WriteLine($"5! is {Person.Factorial(5)}");

            static void Rathalos_Shout(object? sender, EventArgs e)
            {
                if (sender is null) return;
                Person p = (Person)sender;
                WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
            }

            rathalos.Shout += Rathalos_Shout;
            rathalos.Poke();
            rathalos.Poke();
            rathalos.Poke();
            rathalos.Poke();

            // non-generic lookup collection
            System.Collections.Hashtable lookupObject = new();

            lookupObject.Add(key: 1, value: "Alpha");
            lookupObject.Add(key: 2, value: "Beta");
            lookupObject.Add(key: 3, value: "Gamma");
            lookupObject.Add(key: anakin, value: "Delta");

            int key = 2; // lookup the value that has 2 as its key
            WriteLine(format: "Key {0} has value: {1}",
                arg0: key,
                arg1: lookupObject[key]);

            WriteLine(format: "Key {0} has value: {1}",
                arg0: anakin,
                arg1: lookupObject[anakin]);

            // generic lookup collection
            Dictionary<int, string> lookupIntString = new();

            lookupIntString.Add(key: 1, value: "Alpha");
            lookupIntString.Add(key: 2, value: "Beta");
            lookupIntString.Add(key: 3, value: "Gamma");
            lookupIntString.Add(key: 4, value: "Delta");

            key = 3;
            WriteLine(format: "Key {0} has value {1}",
                arg0: key,
                arg1: lookupIntString[key]);

            Person[] people =
            {
                new() {Name = "Simon"},
                new() {Name = "Jenny"},
                new() {Name = "Adam"},
                new() {Name = "Richard"}
            };

            WriteLine("Initial list of people:");
            foreach (Person p in people)
            {
                WriteLine($"    {p.Name}");
            }

            WriteLine("Use Person's IComparable implementation to sort:");
            Array.Sort(people);
            foreach (Person p in people)
            {
                WriteLine($"    {p.Name}");
            }

            DisplacementVector dv1 = new(3, 5);
            DisplacementVector dv2 = new(-2, 7);
            DisplacementVector dv3 = dv1 + dv2;

            WriteLine($"({dv1.X}, {dv1.Y}) + ({dv2.X}, {dv2.Y}) = ({dv3.X}, {dv3.Y}).");

            Employee john = new()
            {
                Name = "John Jones",
                DateOfBirth = new(year: 1990, month: 7, day: 28)
            };
            john.WriteToConsole();
            john.EmployeeCode = "JJ001";
            john.HireDate = new(year: 2014, month: 11, day: 23);
            WriteLine($"{john.Name} was hired on {john.HireDate:dd/MM/yy}");

            WriteLine(john.ToString());

            Employee aliceInEmployee = new()
            { Name = "Alice", EmployeeCode = "AA123" };

            Person aliceInPerson = aliceInEmployee;
            aliceInEmployee.WriteToConsole();
            aliceInPerson.WriteToConsole();
            WriteLine(aliceInEmployee.ToString());
            WriteLine(aliceInPerson.ToString());

            if (aliceInPerson is Employee)
            {
                WriteLine($"{nameof(aliceInPerson)} IS an Employee");
                Employee explicitAlice = (Employee)aliceInPerson;
                // safely do something with explicitAlice
            }

            Employee? aliceAsEmployee = aliceInPerson as Employee; // could be null

            if (aliceAsEmployee != null)
            {
                WriteLine($"{nameof(aliceAsEmployee)} AS an Employee");
            }
        }
    }
}
