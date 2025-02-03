using System;

class ExtendedString
{
    private string data;

    public ExtendedString(string str)
    {
        data = str;
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