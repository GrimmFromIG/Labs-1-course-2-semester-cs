using System;
using System.Collections.Generic;

public abstract class Shape
{
    protected List<(double x, double y)> vertices;

    public Shape(List<(double x, double y)> v)
    {
        vertices = v;
    }

    protected double SideLength(int i, int j)
    {
        double dx = vertices[j].x - vertices[i].x;
        double dy = vertices[j].y - vertices[i].y;
        return Math.Sqrt(dx * dx + dy * dy);
    }

    public abstract void PrintData();
}