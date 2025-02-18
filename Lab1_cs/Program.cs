using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Enter a numeric string: ");
        string input = Console.ReadLine();

        ExtendedString strObj = new ExtendedString(input);

        Console.WriteLine("Initial string: " + strObj.GetString());
        Console.WriteLine("String length: " + strObj.GetLength());

        strObj.RemoveChar5();

        Console.WriteLine("String after deleting char '5': " + strObj.GetString());
        Console.WriteLine("New string length: " + strObj.GetLength());

        Console.WriteLine("\nPress any key to continue");
        Console.ReadKey();
    }
}
