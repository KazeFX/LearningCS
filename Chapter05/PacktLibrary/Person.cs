﻿using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes; // List<T>

namespace Packt.Shared
{
    public partial class Person : object
    {
        // fields
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavouriteAncientWonder;
        public WondersOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>();
        // constants
        public const string Species = "Homo Sapiens";
        //read-only fields
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;

        // constructors
        public Person()
        {
            // set default values for fields
            // including read-only fields
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }

        public Person(string initialName, string homePlanet)
        {
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;
        }

        // methods
        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth:dddd}");
        }

        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}";
        }

        public (string, int) GetFruit()
        {
            return ("Apples", 5);
        }

        public (string Name, int Number) GetNamedFruit()
        {
            return (Name: "Apples", Number: 5);
        }

        public void Deconstruct(out string name, out DateTime dob)
        {
            name = Name;
            dob = DateOfBirth;
        }

        public void Deconstruct(out string name, out DateTime dob, out WondersOfTheAncientWorld fav)
        {
            name = Name;
            dob = DateOfBirth;
            fav = FavouriteAncientWonder;
        }

        public string SayHello()
        {
            return $"{Name} says Hello!";
        }

        public string SayHello(string name)
        {
            return $"{Name} says Hello {name}";
        }

        public string OptionalParameters(string command = "Run!", double number = 0.0, bool active = true)
        {
            return $"{command}, {number}, {active}";
        }

        public void PassingParameters(int x, ref int y, out int z)
        {
            // out parameters cannot have a default
            // AND must be initialized inside the method
            z = 99;

            // increment each parameter
            x++;
            y++;
            z++;
        }

        
    }
}
