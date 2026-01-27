using KazeLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        Person fahim = new()
        {
            Name = "Fahim",
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
        lookupObject.Add(key: fahim, value: "Delta");

        int key = 2; // Look up the value that has 2 as its key.

        WriteLine(format: "Key {0} has value: {1}",
            arg0: key,
            arg1: lookupObject[key]);

        WriteLine(format: "Key {0} has value: {1}",
            arg0: fahim,
            arg1: lookupObject[fahim]);




    }
}