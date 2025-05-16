using System;

public class MathExpression
{
    private double a;
    private double b;
    private double c;
    private double d;
    
    public MathExpression()
    {
        a = 0;
        b = 0;
        c = 0;
        d = 1;
    }

    public MathExpression(double a, double b, double c, double d)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        this.d = d;
    }

    public void SetA(double value) { a = value; }
    public void SetB(double value) { b = value; }
    public void SetC(double value) { c = value; }
    public void SetD(double value)
    {
        if (value == 0)
        {
            throw new ArgumentException("D cannot be zero");
        }
        d = value;
    }

    public double GetA() { return a; }
    public double GetB() { return b; }
    public double GetC() { return c; }
    public double GetD() { return d; }

    private double CustomLog10(double value)
    {
        if (value <= 0)
        {
            throw new ArgumentException("Logarithm argument must be positive");
        }
        
        const double ln10 = 2.30258509299404568402;
        return Math.Log(value) / ln10;
    }

    public double CalculateExpression()
    {
        try
        {
            if (d == 1 || b + c == 0)
            {
                throw new ArgumentException("D cannot be 1 and B + C cannot be zero");
            }
            else if (d == 1)
            {
                throw new ArgumentException("D cannot be 1");
            }
            else if (b + c == 0)
            {
                throw new ArgumentException("B + C cannot be zero");
            }
            
            double logArgument = 4 * b - c;
            double logarithm = CustomLog10(logArgument);
            double expression = (logarithm * a) / (b + c / d - 1);
            
            return expression;
        }
        catch (Exception e)
        {
            throw;
        }
    }
}