using System;

namespace Lecture._14
{
    struct Rectangle
    {
        public int Width { get; private set; }
        public int Higth { get; private set; }
        public Rectangle(int width, int higth)
        {
            Width = width;
            Higth = higth;
        }
        public Rectangle(int value)
        {
            Width = value;
            Higth = value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Rectangle[] rectangleArray = new Rectangle[] { };
            int dublicateCounter = default(int);
            int side = random.Next(1, 10);
            int sideStart = side;

            for (int i = 0; i < 100; i++)
            {
                rectangleArray[i] = new Rectangle(side);
                if (rectangleArray[i].Width == sideStart)
                    dublicateCounter++;
                side = random.Next(1, 10);
            }

            Console.WriteLine("The array of rectangles");

            foreach (Rectangle rectangle in rectangleArray)
            {
                Console.WriteLine(rectangle.Width + " " + rectangle.Higth);
            }

            Console.WriteLine($"The number of dublikates {dublicateCounter - 1}");
        }
    }
}
