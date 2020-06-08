using System;

namespace LetterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            Console.WriteLine("enter the word");

            string wordConsole = Console.ReadLine();

            for (int i = 0; i < wordConsole.Length; i++)
            {
                if (wordConsole[i] == 'a')
                {
                    count++;
                }
            }

            Console.WriteLine("word " + wordConsole + " has " + count + " letters a");
            Console.ReadKey();
        }
    }
}
