using System;

class Program
{
    static void Main()
    {
        Rectangle Q1 = new Rectangle();
        Rectangle Q2 = new Rectangle(0, 0, 6, 4);
        Rectangle Q3 = new Rectangle(Q2);

        Console.WriteLine("Початкові прямокутники:");
        Q1.Display();
        Q2.Display();
        Q3.Display();

        Q1.SetCoordinates(1, 1, 5, 3);
        Console.WriteLine("\nQ1 після зміни координат (по координатам двух вершин):");
        Q1.Display();

        double[] vertices = { 2, 2, 8, 6 };
        Q2.SetCoordinates(vertices);
        Console.WriteLine("\nQ2 після зміни координат (через массив):");
        Q2.Display();

        Q2 = Q2 / 2;
        Console.WriteLine("\nQ2 після зменшення у 2 рази:");
        Q2.Display();

        Q1 = Q3 - Q2;
        Console.WriteLine("\nРезультат віданімання Q3 - Q2 -> Q1:");
        Q1.Display();
    }
}