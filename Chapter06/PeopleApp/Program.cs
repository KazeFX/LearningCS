using KazeLibrary;

Person fahim = new()
{
    Name = "Fahim",
    Born = new(year: 2005, month: 3, day: 25, hour: 0, minute: 0, second: 0, offset: TimeSpan.Zero)
};

fahim.WriteToConsole();

// Implementing functionality using methods.
Person Isa = new() { Name = "Isa" };
Person JackBauer = new() { Name = "Jack Bauer" };
Person Picard = new() { Name = "Picard" };

// Call the instance method to marry Isa and Jackbauer
Isa.Marry(JackBauer);

// Call the static method to marry Jackbauer and Picard.
Person.Marry(Isa, Picard);

Isa.OutputPartners();
JackBauer.OutputPartners();
Picard.OutputPartners();

// Call the instance method to make a baby.
Person baby1 = Isa.ProCreateWith(JackBauer);
baby1.Name = "Jafar";
WriteLine($"{baby1.Name} was born on {baby1.Born}");

// Call the static method to make a baby
Person baby2 = Person.Procreate(Picard, Isa);
baby2.Name = "Worf";

Isa.WriteChildrenToConsole();
JackBauer.WriteChildrenToConsole();
Picard.WriteChildrenToConsole();

for (int i = 0; i < Isa.Children.Count; i++)
{
    WriteLine(format: "     {0}'s child #{1} is named \"{2}\".",
        arg0: Isa.Name, arg1: i, arg2: Isa.Children[i].Name);
}