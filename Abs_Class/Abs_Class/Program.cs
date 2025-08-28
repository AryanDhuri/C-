using System;

abstract class Shape
{
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
}

class Circle :Shape
{
    private double radius;
    public Circle(double r)
    {
        radius = r;
    }
    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
    public override double CalculatePerimeter()
    {
        return 2*Math.PI * radius;
    }
}

class Triangle: Shape
{
    private double side1,side2,side3;
    public Triangle(double s1, double s2, double s3)
    {
        side1 = s1; side2 = s2; side3 = s3;
    }
    public override double CalculateArea()
    {
        double s = (side1+ side2+ side3) / 2;
        return Math.Sqrt(s*(s-side1)*(s-side2)*(s-side3));
    }
    public override double CalculatePerimeter()
    {
        return side1 + side2 + side3;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Shape c = new Circle(5);
        Console.WriteLine("Circle Area"+c.CalculateArea());
        Console.WriteLine("Circle Perimeter" + c.CalculatePerimeter());

        Shape t = new Triangle(3,4,5);
        Console.WriteLine("Triangle Area" + t.CalculateArea());
        Console.WriteLine("Triangle Perimeter" + t.CalculatePerimeter());

    }
}