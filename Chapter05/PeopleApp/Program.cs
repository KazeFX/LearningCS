using Packt.Shared;
using Fruit = (string Name, int Number); // Aliasing a tuple type.

ConfigureConsole(); // Setts current culture to US English.

// Alternatives:
// ConfigureConsole(useComputerCulture: true); // Use your culture.
// ConfigureConsole(culture: "fr-FR"); // Use French culture.

// Person bob = new Person(); // C# 1 or later
// var bob = new Person(); // C# 3 or later.

Person bob = new(); // C# 9 or later.
WriteLine(bob); // Implicit call to ToString();
//WriteLine(bob.ToString()); // Does the same thing.

bob.Name = "Bob Smith";



bob.Born = new DateTimeOffset(
    year: 1965, month: 12, day: 22,
    hour: 16, minute: 28, second: 0,
    offset: TimeSpan.FromHours(-5)); // US Eastern Standard Time

WriteLine(format: "{0} was born on {1:D}.", // Long date
    arg0: bob.Name, arg1: bob.Born);

Person alice = new()
{
    Name = "Alice Jones",
    Born = new(1998, 3, 7, 16, 28, 0,
    TimeSpan.Zero)
};

WriteLine(format: "{0} was born on {1:d}.", // Short date
    arg0: alice.Name, arg1: alice.Born);

bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;

WriteLine(format: "{0}'s favorite wonder is {1}. It's integer is {2}.",
    arg0: bob.Name,
    arg1: bob.FavoriteAncientWonder,
    arg2: (int)bob.FavoriteAncientWonder);

bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;

// bob.BucketList = (WondersOfTheAncientWorld)18;

WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");

// Works with all versions of C#
Person alfred = new Person();
alfred.Name = "Alfred";
bob.Children.Add(alfred);

// Works with C# 3 and later.
bob.Children.Add(new Person { Name = "Bella" });

// Works with C# 9 and later.
bob.Children.Add(new() { Name = "Zoe" });

WriteLine($"{bob.Name} has {bob.Children.Count} children.");

for (int childIndex = 0; childIndex < bob.Children.Count; childIndex++)
{
    WriteLine($"> {bob.Children[childIndex].Name}");
}

foreach (Person child in bob.Children) {
    WriteLine($"{child.Name}");
}

BankAccount.InterestRate = 0.012M; // Store a shared value in static field.

BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mrs. Terra";
jonesAccount.Balance = 2400;
WriteLine(format: "{0} earned {1:C} interest.",
    arg0: jonesAccount.AccountName,
    arg1: jonesAccount.Balance * BankAccount.InterestRate);

BankAccount gerrierAccount = new();
gerrierAccount.AccountName = "Ms. Tifa";
gerrierAccount.Balance = 98;
WriteLine(format: "{0} earned {1:C} interest.",
    arg0: gerrierAccount.AccountName,
    arg1: gerrierAccount.Balance * BankAccount.InterestRate);

WriteLine($"{bob.Name} is a {Person.Species}");
WriteLine($"{bob.Name} was born on {bob.HomePlanet}.");

//Book book = new()
//{
//    Isbn = "344-1337133713137",
//    Title = "Get out of My Swamp"
//};

Book book = new(isbn: "144-124124124124", title: ":D")
{
    Author = "me :D",
    PageCount = 1337
};

WriteLine("{0}: {1} written by {2} has {3:N0} pages.",
    book.Isbn, book.Title, book.Author, book.PageCount);

Person blankPerson = new();

WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
    arg0: blankPerson.Name,
    arg1: blankPerson.HomePlanet,
    arg2: blankPerson.Instantiated);

Person barry = new(initialName: "Barret", homePlanet: "Gaia");

WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
    arg0: barry.Name,
    arg1: barry.HomePlanet,
    arg2: barry.Instantiated);

bob.WriteToConsole();
WriteLine(bob.GetOrigin());
WriteLine(bob.SayHello());
WriteLine(bob.SayHello("Aerith"));
WriteLine(bob.stabbyStab("Bob"));

WriteLine(bob.OptionalParameters(command: "Sneak!", count: 3));
WriteLine(bob.OptionalParameters(3, "Jump!", 98.5));

WriteLine(bob.OptionalParameters(3, number: 52.7, command: "Hide!"));
WriteLine(bob.OptionalParameters(3, "Poke!", active: false));

int a = 10;
int b = 20;
int c = 30;
int d = 40;

WriteLine($"Before: a={a}, b={b}, c={c}, d={d}");

bob.PassingParameters(a, b, ref c, out d);

WriteLine($"After: a={a}, b={b}, c={c}, d={d}");

int e = 50;
int f = 60;
int g = 70;
WriteLine($"Before: e={e}, f={f}, g={g}, h = ?");

// Simplified C# 7 or later syntax for the out parameter.
bob.PassingParameters(e, f, ref g, out int h);
WriteLine($"After: e={e}, f={f}, g={g}, h={h}");

bob.ParamsParameters("Sum using commas", 3, 6, 1, 2);
bob.ParamsParameters("Sum using collection expression", [3, 6, 1, 2]);
bob.ParamsParameters("Sum using explicit array", new int[] { 3, 6, 1, 2 });
bob.ParamsParameters("Sum (empty)");

(string, int) fruit = bob.GetFruit();
WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

//var fruitNamed = bob.GetNamedFruit();
//WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}");

Fruit fruitNamed = bob.GetNamedFruit();
WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}");

var thing1 = ("Tifa", 4);
WriteLine($"{thing1.Item1} has {thing1.Item2} materia.");

var thing2 = (bob.Name, bob.Children.Count);
WriteLine($"{thing2.Name} has {thing2.Count} children.");

(string fruitName, int fruitNumber) = bob.GetNamedFruit();
WriteLine($"Deconstructed tuble: {fruitName}, {fruitNumber}");

var (name1, dob1) = bob; // Implicitly calls the Deconstruct method.
WriteLine($"Deconstructed person: {name1}, {dob1}");

var (name2, dob2, fav2) = bob;
WriteLine($"Deconstructed person: {name2}, {dob2}, {fav2}");

int number = 5;

try
{
    WriteLine($"{number}! is {Person.Factorial(number)}");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType()} says {ex.Message} number was {number}.");
}

Person sam = new()
{
    Name = "Sam",
    Born = new(1987, 6, 20, 0, 0, 0, TimeSpan.Zero)
};

WriteLine(sam.Origin);
WriteLine(sam.Greeting);
WriteLine(sam.Age);

sam.FavoriteIceCream = "Chocolate Fudge";
WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}.");

string color = "Red";

try
{
    sam.FavoritePrimaryColor = color;
    WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}.");
}
catch (Exception ex)
{
    WriteLine("Tried to set {0} to '{1}': {2}", nameof(sam.FavoritePrimaryColor), color, ex.Message);
}

bob.FavoriteAncientWonder = (WondersOfTheAncientWorld)8;
WriteLine($"Bob likes {bob.FavoriteAncientWonder}");

sam.Children.Add(new() { Name = "Captain Kirk", Born = new(2000, 3, 18, 0, 0, 0, TimeSpan.Zero) });

sam.Children.Add(new() { Name = "Picard", Born = new(2020, 12, 12, 0, 0, 0, TimeSpan.Zero) });

// Get using Children list.
WriteLine($"Sam's first child is {sam.Children[0].Name}");
WriteLine($"Sam's second child is {sam.Children[1].Name}");

// Get using the int indexer.
WriteLine($"Sam's first child is {sam[0].Name}");
WriteLine($"Sam's second child is {sam[1].Name}");

// Get using the string indexer.
WriteLine($"Sam's child named Picard is {sam["Picard"].Age} years old.");

// An array containing a mix of passenger types.
Passenger[] passengers =
{
    new FirstClassPassenger {Airmiles = 1_1419, Name = "MisterVFDC"},
    new FirstClassPassenger {Airmiles = 16_562, Name = "Rich"},
    new BusinessClassPassenger {Name = "Doctor Daniel Jackson"},
    new CoachClassPassenger {CarryOnKG = 25.5, Name = "supersonicsjm"},
    new CoachClassPassenger {CarryOnKG = 0, Name = "Gandalf"},
};

foreach (Passenger passenger in passengers)
{
    decimal flightCost = passenger switch
    {
        //FirstClassPassenger p when p.Airmiles > 35_000 => 1_500M,
        //FirstClassPassenger p when p.Airmiles > 15_000 => 1_1750M,
        //FirstClassPassenger _ => 2_000M,
        //FirstClassPassenger p => p.Airmiles switch
        //{
        //    > 35_000 => 1_500M,
        //    > 15_000 => 1_750M,
        //    _        => 2_000M
        //},
        
        // relational pattern with property pattern && nested switch expressions
        FirstClassPassenger { Airmiles: > 35000 } => 1500M,
        FirstClassPassenger { Airmiles: > 15000 } => 1750M,
        FirstClassPassenger                       => 2000M,


        BusinessClassPassenger _ => 1_000M,
        CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
        CoachClassPassenger _ => 650M,
        _ => 800M
    };
    WriteLine($"Flight costs {flightCost:C} for {passenger}");
}

ImmutablePerson jeff = new()
{
    FirstName = "Jeff",
    LastName = "The Landshark"
};
//jeff.FirstName = "Harry";

ImmutableVehicle car = new()
{
    Brand = "Nissan GT-R 2002",
    Color = "Skyline Blue",
    Wheels = 3
};
ImmutableVehicle repaintedCar = car with { Color = "Polymetallic Grey" };
WriteLine($"Original car color was {car.Color}.");
WriteLine($"New car color is {repaintedCar.Color}.");

AnimalClass ac1 = new() { Name = "T-REX" };
AnimalClass ac2 = new() { Name = "T-REX" };
WriteLine($"ac1 == ac2: {ac1 == ac2}");

AnimalRecord ar1 = new() { Name = "RAPTOR" };
AnimalRecord ar2 = new() { Name = "RAPTOR" };
WriteLine($"ar1 == ar2: {ar1 == ar2}");

int number1 = 3;
int number2 = 3;
WriteLine($"number1: {number1}, number2: {number2}");
WriteLine($"number1 == number2: {number1 == number2}");

Person p1 = new() { Name = "Kevin" };
Person p2 = new() { Name = "Kevin" };
WriteLine($"p1: {p1}, p2: {p2}");
WriteLine($"p1.Name: {p1.Name}, p2.Name: {p2.Name}");
WriteLine($"p1 == p2: {p1 == p2}");

Person p3 = p1;
WriteLine($"p3: {p3}");
WriteLine($"p3.Name: {p3.Name}");
WriteLine($"p1 == p3: {p1 == p3}");

// string is the only class reference type implemented to act like a value type for equality.
WriteLine($"p1.Name: {p1.Name}, p2.Name: {p2.Name}");
WriteLine($"p1.Name == p2.Name: {p1.Name == p2.Name}");

ImmutableAnimal oscar = new("Oscar", "Dog");
var (who, what) = oscar; // Calls the Deconstruct method.
WriteLine($"{who} is a {what}");

Headset vp = new("Apple", "Vision Pro");
WriteLine($"{vp.ProductName} is made by {vp.Manufacturer}");

Headset holo = new();
WriteLine($"{holo.ProductName} is made by {holo.Manufacturer}");

Headset mq = new() { Manufacturer = "Meta", ProductName = "Quest 3" };
WriteLine($"{mq.ProductName} is made by {mq.Manufacturer}");