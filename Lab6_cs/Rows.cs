using System;
using System.Linq;
using System.Text;

public class Row
{
    public string Data { get; private set; }

    public Row(string str = "")
    {
        Data = str;
    }

    public void SetData(string str)
    {
        Data = str;
    }

    public void TrimSpaces()
    {
        Data = Data.Trim();
    }

    public void ReplaceMultipleSpaces()
    {
        StringBuilder result = new StringBuilder();
        bool prevSpace = false;
        
        foreach (char c in Data)
        {
            if (c == ' ' || c == '\t')
            {
                if (!prevSpace)
                {
                    result.Append(' ');
                    prevSpace = true;
                }
            }
            else
            {
                result.Append(c);
                prevSpace = false;
            }
        }
        
        Data = result.ToString();
    }

    public double CalculateConsonantPercentage()
    {
        if (string.IsNullOrEmpty(Data)) return 0.0;
        
        string consonants = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";
        string vowels = "aeiouAEIOU";
        
        int consonantCount = 0;
        int letterCount = 0;
        
        foreach (char c in Data)
        {
            if (char.IsLetter(c))
            {
                letterCount++;
                if (consonants.Contains(c))
                {
                    consonantCount++;
                }
            }
        }
        
        return (letterCount == 0) ? 0.0 : ((double)consonantCount / letterCount) * 100.0;
    }

    public int Length()
    {
        return Data.Length;
    }
}