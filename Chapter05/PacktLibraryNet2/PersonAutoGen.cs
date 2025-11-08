using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.Shared;

public partial class Person
{

    // A private backing field to store the property value.
    private string? _favoritePrimaryColor;
    private WondersOfTheAncientWorld _favoriteAncientWonder;

    public WondersOfTheAncientWorld FavoriteAncientWonder
    {
        get { return _favoriteAncientWonder; }
        set
        {
            string wonderName = value.ToString();

            if (wonderName.Contains(','))
            {
                throw new ArgumentException(message: "Favorite ancient wonder can only have a single enum value.", paramName: nameof(FavoriteAncientWonder));
            }
            if (!Enum.IsDefined(typeof(WondersOfTheAncientWorld), value))
            {

            }
        }
    }

    #region Properties: Methods to get and/or set data or state.

    public string Origin
    {
        get
        {
            return string.Format("{0} was born on {1}.",
                arg0: Name, arg1: HomePlanet);
        }
    }

    // Two readonly properties defined using C# 6 or later
    // lampda expression body syntax

    public string Greeting => $"{Name} says Hello!";

    public int Age => DateTime.Today.Year - Born.Year;

    // A read-write property defined using C# 3 auto-syntax.
    public string? FavoriteIceCream { get; set; }

    // A public property to read and write to the field.
    public string? FavoritePrimaryColor
    {
        get
        {
            return _favoritePrimaryColor;
        }
        set
        {
            switch (value?.ToLower())
            {
                case "red":
                case "greaan":
                case "blue":
                    _favoritePrimaryColor = value;
                    break;
                default:
                    throw new ArgumentException($"{value} is not a primary color. " + "Choose from: red, green, blue.");
            }
        }
    }


    #endregion

}
