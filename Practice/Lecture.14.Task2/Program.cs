using System;

namespace Lecture._14.Task2
{
    static class StringExtension
    {
        public static string CutToFive(this String str)
        {
            return str.Remove(5).Insert(5, "...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string someString = "12345678910";

            Console.WriteLine(someString.CutToFive());

            Console.ReadLine();
        }
    }
}
