using System;

namespace GoodDay
{
    class Program
    {
        static void Main(string[] args)
        {
            string morningGreetings = "Good morning, guys!";
            string dayGreetings = "Good day, guys!";
            string eveningGreetings = "Good evening, guys!";
            string nightGreetings = "Good night, guys!";

            string currentGreetings = nightGreetings;

            TimeSpan currentTime = DateTime.Now.TimeOfDay;
            int currentHours = currentTime.Hours;

            if (currentHours>=9 && currentHours<12) { currentGreetings = morningGreetings; }
            if (currentHours>=12 && currentHours<15) { currentGreetings = dayGreetings; }
            if (currentHours>=15 && currentHours<22) { currentGreetings = eveningGreetings; }

            Console.WriteLine(currentGreetings);
            Console.ReadKey();
        }
    }
}
