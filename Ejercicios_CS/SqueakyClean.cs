using System;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        var sb = new StringBuilder();
        bool capitalizeNext = false;

        for (int i = 0; i < identifier.Length; i++)
        {
            char c = identifier[i];

            if (c == ' ')
            {
                sb.Append('_');
            }
            else if (char.IsControl(c))
            {
                sb.Append("CTRL");
            }
            else if (c == '-')
            {
                capitalizeNext = true;
            }
            else if (c >= 'α' && c <= 'ω')
            {
                // Omite letras griegas en minúsculas
                continue;
            }
            else if (char.IsLetter(c))
            {
                if (capitalizeNext)
                {
                    sb.Append(char.ToUpperInvariant(c));
                    capitalizeNext = false;
                }
                else
                {
                    sb.Append(c);
                }
            }
            else if (c == '_')
            {
                sb.Append(c);
            }
        }

        return sb.ToString();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        string[] testCases = {
            "my   Id",
            "my\0Id",
            "kebab-case-variable",
            "my_variable",
            "123my!@#Id456",
            "MyΟβOption",
            "clean-this\0string please"
        };

        Console.WriteLine($"{"Entrada",-28} -> Salida");
        Console.WriteLine(new string('-', 50));

        foreach (string test in testCases)
        {
            string displayInput = test.Replace("\0", "\\0");
            string output = Identifier.Clean(test);

            Console.WriteLine($"{displayInput,-28} -> {output}");
        }
    }
}
