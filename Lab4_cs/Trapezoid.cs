public class Trapezoid : Shape
{
    public Trapezoid(List<(double x, double y)> v) : base(v) { }

    public double Area()
    {
        double a = SideLength(0, 1);
        double b = SideLength(2, 3);
        double h = Math.Abs(vertices[0].y - vertices[2].y);
        return 0.5 * (a + b) * h;
    }

    public double Perimeter()
    {
        return SideLength(0, 1) + SideLength(1, 2) + SideLength(2, 3) + SideLength(3, 0);
    }

    public override void PrintData()
    {
        Console.WriteLine($"Trapezoid: area = {Area()}, perimeter = {Perimeter()}");
    }
}