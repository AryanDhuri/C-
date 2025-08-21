using System;
using ClassLibrary1;
namespace ConsoleApp1

{
        class point
        {
            internal int x;
            internal int y;
            public void Test()
            {
                Console.WriteLine("This is a method in point class");
                Console.WriteLine("Created a point class");
            }
        }

        class Program : point
        {
            static void Main()
            {
                point p = new point();
                Program p1 = new Program();
                p1.Test();
            }
        }
 }

namespace N
{
    class sample
    {
        public void display()
        {
            ConsoleApp1.point p = new ConsoleApp1.point();
        }
    }
}

