using System;

namespace Lecture._6
{
    class Program
    {
        static void Main(string[] args)
        {
            EmptyArray();

            MixArray();



            Console.ReadKey();
        }

        static void EmptyArray()
        {
            int[] someArray = new int[] { };
            Console.WriteLine("The empty array has created");
        }

        static void MixArray()
        {
            object[] mixArray = new object[3] { 32, 'A', "Hello" };
            foreach (object element in mixArray)
            {
                Console.WriteLine(element);
            }

            mixArray[0] = (int)mixArray[0] + 10;
            mixArray[2] = (string)mixArray[2] + ", guys";

            foreach (object element in mixArray)
            {
                Console.WriteLine(element);
            }

        }
    }
}
