using System;

class Animal
{
    public void Sleep()
    {
        Console.WriteLine("Animal is sleeping");
    }
}

class Dog : Animal
{
    public void Eat()
    {
        Console.WriteLine("Dog is eating");
    }
}

class Program
{
   static void Main(string[] args)
    {
        Dog d=new Dog();
        d.Sleep();
        d.Eat();
    }
}