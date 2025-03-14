using System;

class Rectangle
{
    private double[] coords;

    public Rectangle()
    {
        coords = new double[] { 0, 0, 1, 1 };
    }

    public Rectangle(double x1, double y1, double x2, double y2)
    {
        coords = new double[] { x1, y1, x2, y2 };
    }

    public Rectangle(Rectangle other)
    {
        coords = (double[])other.coords.Clone();
    }

    public double Area()
    {
        return Math.Abs((coords[2] - coords[0]) * (coords[3] - coords[1]));
    }

    public double Perimeter()
    {
        return 2 * (Math.Abs(coords[2] - coords[0]) + Math.Abs(coords[3] - coords[1]));
    }

    public void SetCoordinates(double x1, double y1, double x2, double y2)
    {
        coords = new double[] { x1, y1, x2, y2 };
    }

    public void SetCoordinates(double[] vertices)
    {
        if (vertices.Length == 4)
        {
            coords = (double[])vertices.Clone();
        }
    }

    public void Display()
    {
        Console.WriteLine($"Прямокутник: ({coords[0]}, {coords[1]}) -> ({coords[2]}, {coords[3]}) " +
                          $"| Площа: {Area()}, Периметр: {Perimeter()}");
    }

    public static Rectangle operator /(Rectangle rect, double value)
    {
        return new Rectangle(rect.coords[0], rect.coords[1],
            rect.coords[0] + (rect.coords[2] - rect.coords[0]) / value,
            rect.coords[1] + (rect.coords[3] - rect.coords[1]) / value);
    }

    public static Rectangle operator -(Rectangle rect, double value)
    {
        return new Rectangle(rect.coords[0], rect.coords[1],
            rect.coords[2] - value, rect.coords[3] - value);
    }

    public static Rectangle operator -(Rectangle rect1, Rectangle rect2)
    {
        return new Rectangle(rect1.coords[0] - rect2.coords[0], rect1.coords[1] - rect2.coords[1],
            rect1.coords[2] - rect2.coords[2], rect1.coords[3] - rect2.coords[3]);
    }
}