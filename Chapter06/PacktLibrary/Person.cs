﻿using static System.Console;
using System.Collections;

namespace Packt.Shared
{
    public class Person : Object, IComparable<Person>
    {
        //fields
        public string? Name;
        public DateTime DateOfBirth;
        public List<Person> Children = new(); // C# 9 or later

        // methods
        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
        }

        // static method to multiply 
        public static Person Procreate(Person p1, Person p2)
        {
            Person baby = new()
            {
                Name = $"Baby of {p1.Name} and {p2.Name}"
            };

            p1.Children.Add(baby);
            p2.Children.Add(baby);

            return baby;
        }

        // instance method to multiply
        public Person ProcreateWith(Person partner)
        {
            return Procreate(this, partner);
        }

        // operator to multiply
        public static Person operator *(Person p1, Person p2)
        {
            return Person.Procreate(p1, p2);
        }

        // method with a local function
        public static int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException($"{nameof(number)} cannot be less than zero yo.");
            }
            return localFactorial(number);

            int localFactorial(int localNumber) // local function
            {
                if (localNumber < 1) return 1;
                return localNumber * localFactorial(localNumber - 1);
            }
        }

        // delegate field
        public event EventHandler? Shout;

        // data field
        public int AngerLevel;

        // method
        public void Poke()
        {
            AngerLevel++;

            if (AngerLevel >= 3)
            {
                // if something is listening..
                if (Shout != null)
                {
                    // .. then call the delegate
                    Shout(this, EventArgs.Empty);
                }
            }
        }

        public int CompareTo(Person? other) 
        {
            if (Name is null) return 0;
            return Name.CompareTo(other?.Name);
        }

        // overriden methods
        public override string ToString()
        {
            return $"{Name} is a {base.ToString()}";
        }

        public void TimeTravel(DateTime when)
        {
            if (when <= DateTime.Now)
            {
                throw new PersonException("If you travel back in time to a date earlier than your own birth, then the universe will explode!");
            }
            else
            {
                Console.WriteLine($"Welcome to {when:yyyy}!");
            }
        }
    }
}