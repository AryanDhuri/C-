using System;

class reverse_string
{
    static void Main(string[] args)
    {

        Console.WriteLine("enter a sentence");
        string str = Convert.ToString(Console.ReadLine());
        string[] words = str.Split(' ').ToArray();
        for (int i = words.Length - 1; i >= 0; i--)
        {
            Console.Write(words[i]);
        }
    }

}