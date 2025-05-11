using System;

class Program
{
    static void DisplayText(TextContainer text)
    {
        Console.WriteLine("Current text content:");
        for (int i = 0; i < text.Size; i++)
        {
            Console.WriteLine($"[{i}]: {text.GetRow(i).Data}");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        TextContainer text = new TextContainer();
        
        text.AddRow(new Row("   Hello   world!   "));
        text.AddRow(new Row("This    is    a    test"));
        text.AddRow(new Row("   Multiple      spaces     everywhere   "));
        text.AddRow(new Row("NoSpacesHere"));
        text.AddRow(new Row("    "));
        
        Console.WriteLine("Original text:");
        DisplayText(text);
        
        Console.WriteLine($"Length of shortest row: {text.GetShortestRowLength()}");
        Console.WriteLine($"Consonant percentage: {text.GetConsonantPercentage()}%\n");
        
        Console.WriteLine("Processing spaces...");
        text.ProcessSpaces();
        DisplayText(text);
        
        Console.WriteLine("Removing row 1...");
        text.RemoveRow(1);
        DisplayText(text);
        
        Console.WriteLine("Clearing text...");
        text.ClearText();
        DisplayText(text);
        
        Console.WriteLine("Adding new rows...");
        text.AddRow(new Row("New content"));
        text.AddRow(new Row("With less spaces"));
        DisplayText(text);
        
        Console.WriteLine($"New consonant percentage: {text.GetConsonantPercentage()}%");
    }
}