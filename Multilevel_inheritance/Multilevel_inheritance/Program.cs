using System;

class University
{
    public void Usn()
    {
        Console.WriteLine("NU24CA010");
    }
}

class College : University
{
    public void RegNo()
    {
        Console.WriteLine("010");
    }
}

class Student : College
{
    public void RollNo()
    {
        Console.WriteLine("10");
    }
}
 class Program()
{
    static void Main(string[] args)
    {
        Student s = new Student();
        s.Usn();
        s.RegNo();
        s.RollNo();
    }
}