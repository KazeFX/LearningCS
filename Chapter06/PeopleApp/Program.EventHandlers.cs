using KazeLibrary;

partial class Program
{
    // A method to handle the Shout event received by the vader object.
    private static void Vader_Shout(object? sender, EventArgs e)
    {
        // If no sender, then do nothing.
        if (sender is null) return;

        // If sender is not a Person, then do nothing and return; else assign sender to p.
        if (sender is not Person p) return;

        WriteLine($"{p.Name} is this angry: {p.AngerLevel}");
    }

    private static void Vader_Shout_2(object? sender, EventArgs e)
    {
        WriteLine("Stop it!");
    }
}