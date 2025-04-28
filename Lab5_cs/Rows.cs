using System;

public class Row
{
    protected string value;

    public Row(string val)
    {
        value = val;
    }

    public virtual int GetLength()
    {
        return value.Length;
    }

    public virtual void Expand()
    {
    }

    public virtual void Print()
    {
        Console.WriteLine($"{value} (length: {GetLength()})");
    }
}

public class Digits : Row
{
    public Digits(string val) : base(val) { }

    public override int GetLength()
    {
        return value.Length;
    }

    public override void Expand()
    {
        char[] result = new char[value.Length * 2];
        for (int i = 0; i < value.Length; i++)
        {
            result[i * 2] = value[i];
            result[i * 2 + 1] = value[i];
        }
        value = new string(result);
    }
}

public class Symbols : Row
{
    public Symbols(string val) : base(val) { }

    public override int GetLength()
    {
        return value.Length;
    }

    public override void Expand()
    {
        System.Text.StringBuilder result = new System.Text.StringBuilder();
        foreach (char ch in value)
        {
            result.Append(ch);
            if (ch == 'k') result.Append(ch);
        }
        value = result.ToString();
    }
}