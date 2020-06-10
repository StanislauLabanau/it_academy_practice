using System;

namespace Lecture._6
{
    class Program
    {
        static void Main(string[] args)
        {
            EmptyArray();
            Console.ReadKey();
        }

        static void EmptyArray()
        {
            int[] someArray = new int[] { };
            Console.WriteLine("The empty array has created");
        }
    }
}
