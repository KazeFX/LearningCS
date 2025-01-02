using Packt.Shared;
using static System.Console;
using System;

namespace PeopleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person bob = new();
            WriteLine(bob.ToString());

            bob.Name = "Bob Smith";
            bob.DateOfBirth = new DateTime(1965, 12, 22);
            bob.FavouriteAncientWonder = WondersOfTheAncientWorld.HangingGardensOfBabylon;
            bob.BucketList = WondersOfTheAncientWorld.GreatPyramidOfGiza | WondersOfTheAncientWorld.LighthouseOfAlexandria;

            WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}",
                arg0: bob.Name,
                arg1: bob.DateOfBirth);

            WriteLine(format: "{0}'s favorite wonder is {1}. Its integer is {2}",
                arg0: bob.Name,
                arg1: bob.FavouriteAncientWonder,
                arg2: (int)bob.FavouriteAncientWonder);

            WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}.");


            Person Alice = new()
            {
                Name = "Alice Jones",
                DateOfBirth = new (1998, 3, 7) // c# 9.0 and later
            };

            WriteLine(format: "{0} was born on {1:dd MMM yy}",
                arg0: Alice.Name,
                arg1: Alice.DateOfBirth);

            bob.Children.Add(new Person { Name = "Alfred" });
            bob.Children.Add(new Person { Name = "Zoe" });
            //bob.Children.Add(new() { Name = "Zoe" }; // C# 9.0 and later

            WriteLine($"Bob has {bob.Children.Count} children:");
            for (int i = 0; i < bob.Children.Count; i++)
            {
                WriteLine($"    {bob.Children[i].Name}");
            }

            foreach (Person person in bob.Children) { WriteLine(person.Name); }

            BankAccount.InterestRate = 0.012M; // store a shared value

            BankAccount jonesAccount = new();
            jonesAccount.AccountName = "Mrs. Jones";
            jonesAccount.Balance = 2400;

            WriteLine(format: "{0} earned {1:C} interest.",
                arg0: jonesAccount.AccountName,
                arg1: jonesAccount.Balance * BankAccount.InterestRate);

            BankAccount gerrierAccount = new();
            gerrierAccount.AccountName = "Ms. Gerrier";
            gerrierAccount.Balance = 98;

            WriteLine(format: "{0} earned {1:C} in interest.",
                arg0: gerrierAccount.AccountName,
                arg1: gerrierAccount.Balance * BankAccount.InterestRate);

            WriteLine($"{bob.Name} is a {Person.Species}.");
            WriteLine($"{bob.Name} is from {bob.HomePlanet}");

            Person blankPerson = new Person();
            WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}",
                arg0: blankPerson.Name,
                arg1: blankPerson.HomePlanet,
                arg2: blankPerson.Instantiated);

            Person gunny = new(initialName: "Gunny", homePlanet :"Mars");
            WriteLine(format: "{0} of {1} was created on {2:dddd}.",
                arg0: gunny.Name,
                arg1: gunny.HomePlanet,
                arg2: gunny.Instantiated);

            bob.WriteToConsole();
            WriteLine(bob.GetOrigin());

            (string, int) fruit = bob.GetFruit();

            WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

            var fruitNamed = bob.GetNamedFruit();

            WriteLine($"{fruitNamed.Name}, {fruitNamed.Number} there are.");

            var thing1 = ("Neville", 4);
            WriteLine($"{thing1.Item1} has {thing1.Item2} children.");


            

        }
    }
}