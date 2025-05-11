using System;
using System.Collections.Generic;
using System.Linq;

public class TextContainer
{
    private List<Row> rows = new List<Row>();

    public void AddRow(Row row)
    {
        rows.Add(row);
    }

    public void RemoveRow(int index)
    {
        if (index >= 0 && index < rows.Count)
        {
            rows.RemoveAt(index);
        }
    }

    public void ClearText()
    {
        rows.Clear();
    }

    public int GetShortestRowLength()
    {
        if (rows.Count == 0) return 0;
        
        return rows.Min(row => row.Length());
    }

    public double GetConsonantPercentage()
    {
        if (rows.Count == 0) return 0.0;
        
        int totalConsonants = 0;
        int totalLetters = 0;
        
        foreach (Row row in rows)
        {
            string data = row.Data;
            foreach (char c in data)
            {
                if (char.IsLetter(c))
                {
                    totalLetters++;
                    char lowerC = char.ToLower(c);
                    if (lowerC != 'a' && lowerC != 'e' && lowerC != 'i' && 
                        lowerC != 'o' && lowerC != 'u')
                    {
                        totalConsonants++;
                    }
                }
            }
        }
        
        return (totalLetters == 0) ? 0.0 : ((double)totalConsonants / totalLetters) * 100.0;
    }

    public void ProcessSpaces()
    {
        foreach (Row row in rows)
        {
            row.ReplaceMultipleSpaces();
            row.TrimSpaces();
        }
    }

    public int Size
    {
        get { return rows.Count; }
    }

    public Row GetRow(int index)
    {
        return rows[index];
    }
}