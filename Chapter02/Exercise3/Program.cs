using static System.Console;

namespace Exercise3;

class Program
{
    static void Main(string[] args)
    {
        sbyte sbyteEx = default;
        byte byteEx = default;
        short shortEx = default;
        ushort ushortEx = default;
        int intEx = default;
        uint uintEx = default;
        long longEx = default;
        ulong ulongEx = default;
        float floatEx = default;
        double doubleEx = default;
        decimal decimalEx = default;

        Object[] varExamples = new Object[] { sbyteEx, byteEx, shortEx, ushortEx, intEx, uintEx, longEx, ulongEx, floatEx, doubleEx, decimalEx };

        WriteLine("--------------------------------------------------------------------------");
        WriteLine("Type \t Byte(s) of memory \t\t Min \t\t\t Max \t\t\t");
        WriteLine("--------------------------------------------------------------------------");
        for (int i = 0; i < varExamples.Length; i++)
        {
            string temp = varExamples[i].GetType().ToString();
            WriteLine(temp);
        }
    }
}