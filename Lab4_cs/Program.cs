class Program
{
    static void Main()
    {
        List<(double, double)> coords = new List<(double, double)>
        {
            (0, 0), (4, 0), (3, 2), (1, 2)
        };
        
        Trapezoid trap = new Trapezoid(coords);
        trap.PrintData();
    }
}