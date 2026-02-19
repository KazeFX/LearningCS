using System.Text.RegularExpressions; // To use Regex.

Write("Enter your age: ");
string input = ReadLine()!; // Null-forgiving
Regex ageChecker = DigitsOnly;
WriteLine(ageChecker.IsMatch(input) ? "Thank you!" : $"This is not a valid age: {input}");

Write("Enter a new password: ");
input = ReadLine()!;
Regex pwChecker = new(@"[A-Za-z0-9]{8,}[!_?]");
WriteLine(pwChecker.IsMatch(input) ? "Thank you!" : $"Not a valid password. Must contain letters and/or digits and ! _ or ? and be at least 8 characters long.");

// C# 1 to 10: Use escaped double-quote characters \"
// string films = "\"Monsters, Inc.\",\"I, Tonya\",\"Lock, Stock and Two Smoking Barrels\"";

// C# 11 or later: Use """ to start and end a raw string literal
string films = """"Monsters, Inc.","I, Tonya","Lock, Stock and Two Smoking Barrels"""";

WriteLine($"Films to split: {films}");

string[] filmsDumb = films.Split(',');

WriteLine("Splitting with string.Split method:");
foreach (string film in filmsDumb)
{
    WriteLine($"    {film}");
}

Regex csv = CommaSeperator; // I hate regex..

MatchCollection filmsSmart = csv.Matches(films);

WriteLine("Splitting with regular expression:");
foreach (Match film in filmsSmart)
{
    WriteLine($"    {film.Groups[2].Value}");
}