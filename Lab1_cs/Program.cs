using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Введіть цифровий рядок:");

        string input = Console.ReadLine();

        ExtendedString strObj = new ExtendedString(input);

        Console.WriteLine("Початковий рядок: " + strObj.GetString());
        Console.WriteLine("Довжина рядка: " + strObj.GetLength());

        strObj.RemoveChar5();

        Console.WriteLine("Рядок після видалення '5': " + strObj.GetString());
        Console.WriteLine("Нова довжина рядка: " + strObj.GetLength());

        Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
        Console.ReadKey();
    }
}