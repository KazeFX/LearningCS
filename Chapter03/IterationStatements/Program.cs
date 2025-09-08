//int x = 0;
//while (x < 10)
//{
//    WriteLine(x);
//    x++;
//}

//string? actualPassword = "Pa$$w0rd";
//string? password;

//do
//{
//    attempts--;
//    Write("Enter your password: ");
//    password = ReadLine();
//}
//while (password != actualPassword);

//WriteLine("Correcto!");


for (int y = 1; y <= 10; y++)
{
    WriteLine(y);
}

for (int y = 0; y <= 10; y += 3)
{
    WriteLine(y);
}

string[] names = { "Benny", "Astrid", "Feena" };

foreach (string name in names)
{
    WriteLine($"{name} has {name.Length} characters.");
}

// Foreach indepth:
System.Collections.IEnumerator e = names.GetEnumerator();
while (e.MoveNext())
{
    string name = (string)e.Current; // Current is ready-only :D
    WriteLine($"{name} has {name.Length} characters.");
}