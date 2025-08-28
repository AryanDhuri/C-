using System;

class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a  shape");
    }
    public virtual void Erase()
    {
        Console.WriteLine("erasing a shape");
    }
}
class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
    public override void Erase()
    {
        Console.WriteLine("Erasing a circle");
    }
}
class Triangle : Shape 
{ 
    public override void Draw()
    {    
       Console.WriteLine("Drawing a Triangle");
    }
    public override void Erase()
    {
       Console.WriteLine("Erasing a Traingle");
    }

}

class Square : Shape
{
    public override void Draw()
    {
       Console.WriteLine("Drawing a Square");
    }
    public override void Erase()
    {
       Console.WriteLine("Erasing a Square");
    }
}

class Program
{
    static void Main(string[] args)    
    {
        Shape[] shapes = { new Circle(), new Triangle(), new Square() };  
        foreach(Shape s in shapes)
        {
            s.Draw();
            s.Erase();
        }

    }    
}