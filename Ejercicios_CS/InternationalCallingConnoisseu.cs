using System;
using System.Collections.Generic;

public static class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary()
    {
        return new Dictionary<int, string>();
    }

    public static Dictionary<int, string> GetExistingDictionary()
    {
        return new Dictionary<int, string>
        {
            [1] = "United States of America",
            [55] = "Brazil",
            [91] = "India"
        };
    }

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {
        var dict = new Dictionary<int, string>();
        dict.Add(countryCode, countryName);
        return dict;
    }

    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        existingDictionary.Add(countryCode, countryName);
        return existingDictionary;
    }

    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        if (existingDictionary.TryGetValue(countryCode, out string? countryName))
        {
            return countryName;
        }

        return string.Empty;
    }

    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
    {
        return existingDictionary.ContainsKey(countryCode);
    }

    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if (existingDictionary.ContainsKey(countryCode))
        {
            existingDictionary[countryCode] = countryName;
        }

        return existingDictionary;
    }

    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        existingDictionary.Remove(countryCode);
        return existingDictionary;
    }

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {
        string longestCountryName = string.Empty;

        foreach (var name in existingDictionary.Values)
        {
            if (name.Length > longestCountryName.Length)
            {
                longestCountryName = name;
            }
        }

        return longestCountryName;
    }
}

class DialingCodesProgram
{
    static void Main(string[] args)
    {
        // 1. Obtener diccionario inicial
        var codes = DialingCodes.GetExistingDictionary();
        Console.WriteLine("--- Diccionario Inicial ---");
        PrintDictionary(codes);

        // 2. Agregar un nuevo país
        DialingCodes.AddCountryToExistingDictionary(codes, 44, "United Kingdom");
        Console.WriteLine("\n--- Tras agregar Reino Unido (44) ---");
        PrintDictionary(codes);

        // 3. Consultar país por código
        int searchCode = 55;
        string country = DialingCodes.GetCountryNameFromDictionary(codes, searchCode);
        Console.WriteLine($"\nPaís con código {searchCode}: {country}");

        // 4. Verificar existencia de un código
        int checkCode = 999;
        bool exists = DialingCodes.CheckCodeExists(codes, checkCode);
        Console.WriteLine($"¿Existe el código {checkCode}?: {exists}");

        // 5. Actualizar un país existente
        DialingCodes.UpdateDictionary(codes, 1, "USA");
        Console.WriteLine("\n--- Tras actualizar código 1 a 'USA' ---");
        PrintDictionary(codes);

        // 6. Eliminar un país
        DialingCodes.RemoveCountryFromDictionary(codes, 91);
        Console.WriteLine("\n--- Tras eliminar código 91 (India) ---");
        PrintDictionary(codes);

        // 7. Encontrar el nombre de país más largo
        string longest = DialingCodes.FindLongestCountryName(codes);
        Console.WriteLine($"\nPaís con el nombre más largo: {longest}");
    }

    static void PrintDictionary(Dictionary<int, string> dict)
    {
        foreach (var kvp in dict)
        {
            Console.WriteLine($"[{kvp.Key}] -> {kvp.Value}");
        }
    }
}