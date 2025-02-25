using System;

public class StringProcessor
{
    private string str;

    public StringProcessor()
    {
        str = "";
    }

    public StringProcessor(string inputStr)
    {
        str = inputStr;
    }

    public StringProcessor(StringProcessor other)
    {
        str = other.str;
    }

    ~StringProcessor()
    {
        Console.WriteLine("Объект уничтожен. Строка: " + str);
    }

    public int GetLength()
    {
        return str.Length;
    }

    public void RemoveFives()
    {
        str = str.Replace("5", "");
    }

    public string GetString()
    {
        return str;
    }
}
