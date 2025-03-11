using System;

class Program
{
    static void Main()
    {
        Rectangle Q1 = new Rectangle(); // Конструктор за замовчуванням
        Rectangle Q2 = new Rectangle(0, 0, 6, 4); // Конструктор з параметрами
        Rectangle Q3 = new Rectangle(Q2); // Конструктор копіювання

        Console.WriteLine("Початкові прямокутники:");
        Q1.Display();
        Q2.Display();
        Q3.Display();

        Q2 = Q2 / 2;
        Console.WriteLine("\nQ2 після зменшення у 2 рази:");
        Q2.Display();

        Q1 = Q3 - Q2;
        Console.WriteLine("\nРезультат віднімання Q3 - Q2 -> Q1:");
        Q1.Display();
    }
}