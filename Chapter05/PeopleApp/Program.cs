﻿using Packt.Shared;
using static System.Console;
using System;
using System.Runtime.CompilerServices;

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

            var thing2 = (bob.Name, bob.Children.Count);
            WriteLine($"{thing2.Name} has {thing2.Count} children.");

            // Deconstructing a Person

            var (name1, dob1) = bob;
            WriteLine($"Deconstructed: {name1}. {dob1}");

            var (name2, dob2, fav2) = bob;
            WriteLine($"Deconstructed: {name2}, {dob2}, {fav2}");

            WriteLine($"{bob.SayHello()}");
            WriteLine($"{bob.SayHello("Emily")}");

            WriteLine(bob.OptionalParameters("Jump!", 98.5));

            WriteLine(bob.OptionalParameters(number: 52.7, command: "Hide!"));
            WriteLine(bob.OptionalParameters("Poke!", active: false));

            int a = 10;
            int b = 20;
            int c = 30;

            WriteLine($"Before: a = {a}, b = {b}, c = {c}");
            bob.PassingParameters(a, ref b, out c);
            WriteLine($"After: a = {a}, b = {b}, c = {c}");

            int d = 10;
            int e = 20;

            WriteLine($"Before: d = {d}, e = {e}, f doesn't exist yet!");
            bob.PassingParameters(d, ref e, out int f);
            WriteLine($"After: d = {d}, e = {e}, f = {f}");

            Person sam = new()
            {
                Name = "Sam",
                DateOfBirth = new(1972, 1, 27)
            };

            WriteLine(sam.Origin);
            WriteLine(sam.Greeting);
            WriteLine(sam.Age);

            sam.FavoriteIceCream = "Banana Split";
            WriteLine($"{sam.Name}'s favorite ice cream is {sam.FavoriteIceCream}");
            sam.FavoritePrimaryColor = "Red";
            WriteLine(sam.FavoritePrimaryColor);

            sam.Children.Add(new() { Name = "Charlie" });
            sam.Children.Add(new() { Name = "Ella" });

            WriteLine(sam.Children[0].Name);
            WriteLine(sam.Children[1].Name);
            WriteLine(sam[0].Name);
            WriteLine(sam[1].Name);

            object[] passengers = {
                new FirstClassPassenger {AirMiles = 1_419},
                new FirstClassPassenger {AirMiles = 16_562 },
                new BusinessClassPassenger(),
                new CoachClassPassenger {CarryOnKG = 25.7},
                new CoachClassPassenger {CarryOnKG = 0 },
            };

            foreach (object passenger in passengers)
            {
                decimal flightCost = passenger switch
                {
                    /* C# 8 syntax
                    FirstClassPassenger p when p.AirMiles > 35000 => 1500M,
                    FirstClassPassenger p when p.AirMiles > 15000 => 1750M,
                    FirstClassPassenger _ => 2000M, */

                    // C# 9 and later
                    FirstClassPassenger p => p.AirMiles switch
                    {
                        > 35000 => 1500M,
                        > 15000 => 1750M,
                        _ => 2000M
                    },

                    BusinessClassPassenger _ => 1000M,
                    CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
                    CoachClassPassenger _ => 650M,
                    _ => 800M
                };
                WriteLine($"Flight costs {flightCost:C} for {passenger}");
            }

            ImmutablePerson jeff = new()
            {
                FirstName = "Jeff",
                LastName = "Winger"
            };

            //jeff.FirstName = "Geoff"; // won't work with init property


            ImmutableVehicle car = new()
            {
                Brand = "Mazda MX-5 RF",
                Color = "Soul Red Crystal Metallic",
                Wheels = 4
            };

            ImmutableVehicle repaintedCar = car with { Color = "Polymetal Grey Metallic" };

            WriteLine($"Original car color was {car.Color}.");
            WriteLine($"New car color is {repaintedCar.Color}");

            ImmutableAnimal oscar = new("Oscar", "Shipom");
            var (who, what) = oscar; // calls Deconstruct method
            WriteLine($"{who} is a {what}.");
        }
    }
}