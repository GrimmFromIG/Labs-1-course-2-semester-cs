using System;

class Rectangle
{
    private double x1, y1, x2, y2;

    // Конструктор за замовчуванням
    public Rectangle()
    {
        x1 = 0;
        y1 = 0;
        x2 = 1;
        y2 = 1;
    }

    // Конструктор з параметрами
    public Rectangle(double x1, double y1, double x2, double y2)
    {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
    }

    // Конструктор копіювання
    public Rectangle(Rectangle other)
    {
        x1 = other.x1;
        y1 = other.y1;
        x2 = other.x2;
        y2 = other.y2;
    }

    public double Area()
    {
        return Math.Abs((x2 - x1) * (y2 - y1));
    }

    public double Perimeter()
    {
        return 2 * (Math.Abs(x2 - x1) + Math.Abs(y2 - y1));
    }

    public static Rectangle operator -(Rectangle rect, double value)
    {
        return new Rectangle(rect.x1, rect.y1, rect.x2 - value, rect.y2 - value);
    }

    public static Rectangle operator /(Rectangle rect, double value)
    {
        return new Rectangle(rect.x1, rect.y1, rect.x1 + (rect.x2 - rect.x1) / value, rect.y1 + (rect.y2 - rect.y1) / value);
    }

    public static Rectangle operator -(Rectangle rect1, Rectangle rect2)
    {
        return new Rectangle(rect1.x1 - rect2.x1, rect1.y1 - rect2.y1, rect1.x2 - rect2.x2, rect1.y2 - rect2.y2);
    }

    public void Display()
    {
        Console.WriteLine($"Прямокутник: ({x1}, {y1}) -> ({x2}, {y2}) | Площа: {Area()}, Периметр: {Perimeter()}");
    }
}