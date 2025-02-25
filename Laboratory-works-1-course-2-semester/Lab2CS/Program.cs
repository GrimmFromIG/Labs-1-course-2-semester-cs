using System;

class Program
{
    static void Main()
    {
        StringProcessor sp1 = new StringProcessor("12345567890");
        StringProcessor sp2 = new StringProcessor(sp1);
        Console.WriteLine("Начальная строка: " + sp1.GetString());

        sp1.RemoveFives();
        Console.WriteLine("Строка после удаления '5': " + sp1.GetString());
        Console.WriteLine("Длина измененной строки: " + sp1.GetLength());

        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}
