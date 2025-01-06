using Microsoft.Win32.SafeHandles;
using Packt.Shared;
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
            int samAngry = 0;
            while (samAngry < int.MaxValue)
            {
                samAngry++;
            }

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




        }
    }
}
