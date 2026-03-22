using Kaze.Shared; // To use Book
using System.Text.Json; // To use JsonSerializer.

Book mysteryBook = new(title: "Scary mysterious things")
{
    Author = "Me :D",
    PublishDate = new(year: 2026, month: 3, day: 22),
    Pages = 9001,
    Created = DateTimeOffset.UtcNow,
};

JsonSerializerOptions options = new()
{
    IncludeFields = true, // Include all fields
    PropertyNameCaseInsensitive = true,
    WriteIndented = true,
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
};

string path = Combine(CurrentDirectory, "book.json");

using (Stream fileStream = File.Create(path))
{
    JsonSerializer.Serialize(utf8Json: fileStream, value: mysteryBook, options);
}

WriteLine("**** File Info ****");
WriteLine($"File: {GetFileName(path)}");
WriteLine($"Path: {GetDirectoryName(path)}");
WriteLine($"Size: {new FileInfo(path).Length:N0} bytes.");
WriteLine("/--------------------");
WriteLine(File.ReadAllText(path));
WriteLine("/--------------------");