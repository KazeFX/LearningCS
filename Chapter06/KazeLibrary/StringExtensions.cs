using System.Text.RegularExpressions; // to use regex.

namespace KazeLibrary;

public static class StringExtensions
{
    public static bool IsValidEmail(this string input)
    {
        // Use a simple regex to check that the input is a valid email.

        return Regex.IsMatch(input, @"[a-zA-Z0-9\.-_]+@[a-zA-Z0-9\.-_]+");
    }
}