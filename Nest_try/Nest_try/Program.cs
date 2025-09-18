using System;

class Program
{
    static void Main(string[] args)
    {
       
        try
        {
            try
            { 
                Console.WriteLine("Enter a number");
                int d = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a number");
                int divisor = Convert.ToInt32(Console.ReadLine());
                int dividebyzero = d / divisor;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Inner catch exception " + e.Message);
            }
        }
        catch (DivideByZeroException e)
        { 
            Console.WriteLine("outer catch excecuted "+ e.Message);
        
        }
    }
}