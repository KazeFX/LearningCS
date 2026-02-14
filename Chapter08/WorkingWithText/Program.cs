using System.Globalization; // To use CultureInfo

OutputEncoding = System.Text.Encoding.UTF8; // Enable Euro symbol.

string city = "London";
WriteLine($"{city} is {city.Length} characters long.");

WriteLine($"First char is {city[0]} and fourth is {city[3]}.");

string cities = "Tokyo,Sapporo,Fukuoka,Yokohama,Osaka,Nagano";

string[] citiesArray = cities.Split(',');

WriteLine($"There are {citiesArray.Length} items in the array:");

foreach (string item in citiesArray)
{
    WriteLine($"    {item}");
}

string fullName = "Alan Shore";

int indexOfTheSpace = fullName.IndexOf(' ');

string firstName = fullName.Substring(startIndex: 0, length: indexOfTheSpace);

string lastName = fullName.Substring(startIndex: indexOfTheSpace + 1);

WriteLine($"Original: {fullName}");
WriteLine($"Swapped: {lastName}, {firstName}");

string company = "APPLE";
WriteLine($"Text: {company}");
WriteLine("Starts with A: {0}, contains a L: {1}",
    arg0: company.StartsWith('A'),
    arg1: company.Contains('L'));

CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

string text1 = "Vader";
string text2 = "VADER";

WriteLine($"text1: {text1}, text2: {text2}");

WriteLine("Compare: {0}.", string.Compare(text1, text2));

WriteLine("Compare (ignoreCase): {0}.", string.Compare(text1, text2, StringComparison.InvariantCultureIgnoreCase));

// German string comparisons

CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("de-DE");

text1 = "Strasse";
text2 = "Straße";

WriteLine($"text1: {text1}, text2: {text2}");

WriteLine("Compare: {0}.", 
    string.Compare(text1, text2, CultureInfo.CurrentCulture, CompareOptions.IgnoreNonSpace));

WriteLine("Compare (IgnoreCase, IgnoreNonSpace): {0}.", 
    string.Compare(text1, text2, CultureInfo.CurrentCulture, CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreCase));

WriteLine("Compare (InvariantCultureIgnoreCase): {0}.",
    string.Compare(text1, text2, StringComparison.InvariantCultureIgnoreCase));

string recombined = string.Join(" => ", citiesArray);
WriteLine(recombined);

CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

string fruit = "Raspberries";
decimal price = 0.39M;
DateTime when = DateTime.Today;

WriteLine($"Interpolated: {fruit} cost {price:C} on {when:dddd}.");
WriteLine(string.Format("string.Format: {0} cost {1:c} on {2:dddd}.",
    arg0: fruit, arg1: price, arg2: when));