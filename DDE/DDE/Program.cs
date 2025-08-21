namespace DDE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.Name = "Parker";
            Console.WriteLine("Please Enter a Name:");
            Person Age = 90;

            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

        }
    }
}
