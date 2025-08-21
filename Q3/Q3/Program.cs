using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lucky Ticket Numbers are:");
        for(int i =1; i<=100; i++)
        {
            if(i%4==0 && i % 6 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}