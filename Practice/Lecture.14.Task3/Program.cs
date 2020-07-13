using System;
using System.Collections.Generic;

namespace Lecture._14.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Neighbor> floorNeighbours = new List<Neighbor>();
            floorNeighbours.Add(new Neighbor("first", "1", "1111"));
            floorNeighbours.Add(new Neighbor("second", "2", "2222"));
            floorNeighbours.Add(new Neighbor("third", "3", "3333"));

            Console.WriteLine("Enter flat number");
            string flatNumber = Console.ReadLine();
                       
            foreach (Neighbor neighbor in floorNeighbours)
            {
                neighbor.ShowNumber(flatNumber);
            }
        }
    }
}
