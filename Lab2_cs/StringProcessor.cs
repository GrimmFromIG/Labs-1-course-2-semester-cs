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
        if (IsNumeric(inputStr))
        {
            str = inputStr;
        }
        else
        {
            Console.WriteLine("Error: String contains non-numeric symbols. Enter a valid numeric string.");
            str = GetValidNumericInput();
        }
    }

    public StringProcessor(StringProcessor other)
    {
        this.str = other.str;
    }

    public string GetString()
    {
        return str;
    }

    public int GetLength()
    {
        return str.Length;
    }

    public void RemoveFives()
    {
        string result = "";
        foreach (char c in str)
        {
            if (c != '5')
            {
                result += c;
            }
        }
        str = result;
    }

    public void SetString(string newStr)
    {
        if (IsNumeric(newStr))
        {
            str = newStr;
        }
        else
        {
            Console.WriteLine("Error: New string contains non-numeric symbols. Keeping the old string.");
        }
    }

    private static bool IsNumeric(string input)
    {
        return !string.IsNullOrEmpty(input) && input.All(char.IsDigit);
    }

    private static string GetValidNumericInput()
    {
        string input;
        bool isValid;

        do
        {
            Console.Write("Enter a numeric string: ");
            input = Console.ReadLine() ?? "";
            isValid = IsNumeric(input);

            if (!isValid)
            {
                Console.WriteLine("Error: String contains non-numeric symbols. Try again.");
            }
        } while (!isValid);

        return input;
    }
}