using System.Globalization; // To use CultureInfo


// Set current culture to US English so that all readers see the same output as shown in the book.
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

int numberOfApples = 12;
decimal pricePerApple = 0.35M;

WriteLine(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);

string formatted = string.Format(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);

//WriteToFile(formatted); // Writes the string into a file.

// The following statement must be all on one line when using C# 10 or earlier. If using C# 11 or later, we can include a line break in the middle of an expression but not in the string text.
WriteLine($"{numberOfApples} apples cost {pricePerApple
    * numberOfApples:C}");

string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
int bananasCount = 56789;

WriteLine();

WriteLine(format: "{0,-10} {1,6}",
    arg0: "Name", arg1: "Count");

WriteLine(format: "{0,-10} {1,6:N0}",
    arg0: applesText, arg1: applesCount);

WriteLine(format: "{0,-10} {1,6:N0}",
    arg0: bananasText, arg1: bananasCount);

decimal value = 0.325M;
WriteLine("Currency: {0:C}, Percentage: {0:0.0%}", value);

WriteLine("Type your first name and press ENTER: ");
string? firstName = ReadLine();

WriteLine("Type your age and press ENTER: ");
string age = ReadLine()!;

WriteLine($"Hello {firstName}, you look good for {age}.");

Write("Press any key combination: ");
ConsoleKeyInfo key = ReadKey();
WriteLine();
WriteLine("Key: {0}, Char: {1}, Modifier: {2}",
    arg0: key.Key, arg1: key.KeyChar, arg2: key.Modifiers);