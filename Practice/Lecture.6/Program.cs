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

            mixArray[1] = (int)mixArray[1] + 10;
            mixArray[3] = (string)mixArray[3] + ", guys";

            foreach (object element in mixArray)
            {
                Console.WriteLine(element);
            }
        }
    }
}
