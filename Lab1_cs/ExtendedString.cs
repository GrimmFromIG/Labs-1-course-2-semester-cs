using System;

class ExtendedString
{
    private string data;

    public ExtendedString(string str)
    {
        if (IsNumeric(str))
        {
            data = str;
        }
        else
        {
            Console.WriteLine("String contain non numeric symbols. Try again");
            data = GetValidNumericInput(); 
        }
    }

    private static string GetValidNumericInput()
    {
        string input;
        bool isValid;

        do
        {
            Console.Write("Enter a numeric string: ");
            input = Console.ReadLine();
            isValid = IsNumeric(input);

            if (!isValid)
            {
                Console.WriteLine("String contain non numeric symbols. Try again");
            }

        } while (!isValid);

        return input;
    }

    private static bool IsNumeric(string str)
    {
        foreach (char c in str)
        {
            if (!char.IsDigit(c))
                return false;
        }
        return true;
    }

    public string GetString()
    {
        return data;
    }

    public int GetLength()
    {
        return data.Length;
    }

    public void RemoveChar5()
    {
        data = data.Replace("5", "");
    }
}
