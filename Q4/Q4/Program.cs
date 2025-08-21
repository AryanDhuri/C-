using System;

class College
{
    protected void show_details()
    {
        Console.WriteLine("Nu24uca010");
    }
}

class Student : College
{
    public void Display()
    {
        show_details();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();
        s.Display();
    }
}