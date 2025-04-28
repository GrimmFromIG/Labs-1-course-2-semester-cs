using System;
using System.Collections.Generic;

class Program
{
    static Random random = new Random();

    static string GenerateRandomDigitsString(int maxLength = 10)
    {
        int len = random.Next(1, maxLength + 1);
        char[] result = new char[len];
        for (int i = 0; i < len; ++i)
        {
            result[i] = (char)('0' + random.Next(0, 10));
        }
        return new string(result);
    }

    static string GenerateRandomSymbolStringWithK(int maxLength = 10)
    {
        int len = random.Next(1, maxLength);
        char[] result = new char[len];
        for (int i = 0; i < len; ++i)
        {
            result[i] = (char)('a' + random.Next(0, 26));
        }
        int insertPos = random.Next(0, len + 1);
        return new string(result).Insert(insertPos, "k");
    }

    static Row GenerateRandomRow()
    {
        if (random.Next(0, 2) == 0)
        {
            return new Digits(GenerateRandomDigitsString());
        }
        else
        {
            return new Symbols(GenerateRandomSymbolStringWithK());
        }
    }

    static void Process(Row r)
    {
        Console.Write("Before: ");
        r.Print();
        r.Expand();
        Console.Write("After: ");
        r.Print();
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        List<Row> rows = new List<Row>();

        for (int i = 0; i < 3; ++i)
        {
            rows.Add(GenerateRandomRow());
        }

        foreach (Row r in rows)
        {
            Process(r);
        }
    }
}