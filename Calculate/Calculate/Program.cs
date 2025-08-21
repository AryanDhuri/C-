using System;

abstract class Shape
{
    public abstract void Calculate_area();
}

class Circle:Shape
{
    public override void Calculate_area()
    {
        Console.WriteLine("Enter radius");
        int r = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The Area of Circle is" + 3.14*r*r);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle c = new Circle();
        c.Calculate_area();
    }
}