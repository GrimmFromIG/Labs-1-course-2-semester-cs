using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a numeric string:");
        string input = Console.ReadLine() ?? "";
        StringProcessor strObj = new StringProcessor(input);

        Console.WriteLine("Initial string: " + strObj.GetString());
        Console.WriteLine("String length: " + strObj.GetLength());

        strObj.RemoveFives();
        Console.WriteLine("String after deleting char '5': " + strObj.GetString());
        Console.WriteLine("New string length: " + strObj.GetLength());
    }
}