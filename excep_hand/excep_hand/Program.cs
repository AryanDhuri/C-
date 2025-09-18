using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter a Number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a Number");
            int b = Convert.ToInt32(Console.ReadLine());

            int result = a / b;
            Console.WriteLine($"Result: {result}");

        }
        catch (DivideByZeroException)
        {
            Console.WriteLine(" Error: Division by zero");

        }
        catch (FormatException) 
        {
            Console.WriteLine(" Error: Format Exception");
        }
        finally
        {
            Console.WriteLine("Program Executed Succesfully");
        }

    }
}