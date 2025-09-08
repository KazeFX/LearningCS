string[] names;

names = new string[4];

names[0] = "Benny";
names[1] = "Feena";
names[2] = "Astrid";
names[3] = "Aki";

for (int i = 0; i < names.Length; i++)
{
    WriteLine($"{names[i]} is at position {i}.");
}

string[] names2 = { "Kate", "Bilbo", "Frodo", "Sauron" };

string[,] grid1 = // two-dimensional array
{
    {"Alpha", "Beta", "Gamma", "Delta" },
    {"Benny", "Feena", "Astrid", "Aki" },
    {"Yen", "Perna", "Jakke", "Habbarn" }
};

WriteLine($"1st dimension, lower bound: {grid1.GetLowerBound(0)}");
WriteLine($"1st dimension, upper bound: {grid1.GetUpperBound(0)}");
WriteLine($"2nd dimension, lower bound: {grid1.GetLowerBound(1)}");
WriteLine($"2nd dimension, upper bound: {grid1.GetUpperBound(1)}");

for (int row = 0; row <= grid1.GetUpperBound(0); row++)
{
    for (int col = 0; col <= grid1.GetUpperBound(1); col++)
    {
        WriteLine($"Row {row}, Columns {col}: {grid1[row, col]}");
    } 
}


string[,] grid2 = new string[3, 4];

grid2[0, 0] = "Celerum";

string[][] jaggedArray =
{
    new[] {"1", "2", "3"},
    new[] {"4", "5", "6", "7"},
    new[] {"8", "9"}
};

WriteLine("Upper bound of the MATRIX is: {0}", jaggedArray.GetUpperBound(0));

for (int array = 0; array <= jaggedArray.GetUpperBound(0); array++)
{
    WriteLine("Upper bound of array {0} is: {1}",
        arg0: array,
        arg1: jaggedArray[array].GetUpperBound(0));
}

for (int row = 0; row <= jaggedArray.GetUpperBound(0); row++)
{
    for (int col = 0; col <= jaggedArray[row].GetUpperBound(0); col++)
    {
        WriteLine($"Row {row}, Column {col}: {jaggedArray[row][col]}");
    }
}

int[] sequentialNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] oneTwoNumbers = { 1, 2 };
int[] oneTwoTenNumbers = { 1, 2, 10 };
int[] oneTwoThreeTenNumbers = { 1, 2, 3, 10 };
int[] primeNumbers = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
int[] fibonacciNumbers = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };
int[] emptyNumbers = Array.Empty<int>();
int[] threeNumbers = { 9, 7, 5 };
int[] sixNumbers = { 9, 7, 5, 4, 2, 10 };

WriteLine($"{nameof(sequentialNumbers)}: {CheckSwitch(sequentialNumbers)}");
WriteLine($"{nameof(oneTwoNumbers)}: {CheckSwitch(oneTwoNumbers)}");
WriteLine($"{nameof(oneTwoTenNumbers)}: {CheckSwitch(oneTwoTenNumbers)}");
WriteLine($"{nameof(oneTwoThreeTenNumbers)}: {CheckSwitch(oneTwoThreeTenNumbers)}");
WriteLine($"{nameof(primeNumbers)}: {CheckSwitch(primeNumbers)}");
WriteLine($"{nameof(fibonacciNumbers)}: {CheckSwitch(fibonacciNumbers)}");
WriteLine($"{nameof(emptyNumbers)}: {CheckSwitch(emptyNumbers)}");
WriteLine($"{nameof(threeNumbers)}: {CheckSwitch(threeNumbers)}");
WriteLine($"{nameof(sixNumbers)}: {CheckSwitch(sixNumbers)}");

static string CheckSwitch(int[] values) => values switch
{
    [] => "Empty array",
    [1, 2, _, 10] => "Contains 1, 2, any single number, 10.",
    [1, 2, .., 10] => "Contains 1, 2, any range including empty, 10",
    [1, 2] => "Contains 1 then 2",
    [int item1, int item2, int item3] => $"Contains {item1} then {item2} then {item3}.",
    [0, _] => "Starts with 0, then one other number.",
    [0, ..] => "Starts with 0, then any range of numbers.",
    [2, .. int[] others] => $"Starts with 2, then {others.Length} more numbers.",
    [..] => "Any items in any order.",
};