using System;

interface Resizable
{
    void ResizeWidth(int width);
    void ResizeHeight(int height);
}

class Rectangle : Resizable
{
    private int width;
    private int height;
    public Rectangle(int w, int h)
    {
        width = w; height = h;
    }
    public void ResizeWidth(int newwidth)
    {
        width = newwidth;
        Console.WriteLine("New Width =" + width);
    }
    public void ResizeHeight( int newHeight)
    {
        height = newHeight;
        Console.WriteLine("New Height =" + height);
    }
    public void Display()
    {
        Console.WriteLine("Rectangle Width = " + width+"Height=" +height);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle(10, 20);
        rect.Display();
        rect.ResizeWidth(30);
        rect.ResizeHeight(40);
        rect.Display();
    }
}
