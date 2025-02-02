
using System; // String
using System.Xml.Linq; // adding namespace for XDocument with 'using'
using static System.Console;

namespace AssembliesAndNamespaces
{
    public class Program
    {

        XDocument doc = new();

        static void Main(string[] args)
        {
            string s1 = "Hello";
            string s2 = "World";

            WriteLine($"{s1} {s2}");
        }
    }
}