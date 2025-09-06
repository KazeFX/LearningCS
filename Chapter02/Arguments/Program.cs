WriteLine($"There are {args.Length} arguments.");

foreach (string arg in args)
{
    WriteLine(arg);
}

if (args.Length < 3)
{
    WriteLine("Specify two colors and cursor size");
    WriteLine("dotnet run red yellow 50");
    return; // Stop running.
}

ForegroundColor = (ConsoleColor)Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[0], ignoreCase: true);

BackgroundColor = (ConsoleColor)Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[1], ignoreCase: true);

try
{
    CursorSize = int.Parse(args[2]);
}
catch (PlatformNotSupportedException)
{
    WriteLine("Current platform doesn't support cursor change. >:(");
}