using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        try
        {
            List<MathExpression> expressions = new List<MathExpression>
            {
                new MathExpression(1, 2, 50, 4),
                new MathExpression(2, 3, 4, 5),
                new MathExpression(3, 4, -4, 1)
            };

            for (int i = 0; i < expressions.Count; ++i)
            {
                try
                {
                    double result = expressions[i].CalculateExpression();
                    Console.WriteLine($"Expression {i+1} result: {result}");
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine($"Error calculating expression {i+1}: {e.Message}");
                }
            }
        }
        catch
        {
            Console.Error.WriteLine("Unexpected error occurred");
            Environment.Exit(1);
        }
    }
}