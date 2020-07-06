using System;

namespace Lecture._12
{
    public class Uniqueltem
    {
        static int Id { get; set; }

        static Uniqueltem()
        {
            Id = Id + 1;
        }

        public static void SetFirstId(int id)
        {
            Id = id;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Uniqueltem.SetFirstId(10);
            Uniqueltem object1 = new Uniqueltem();
            Uniqueltem object2 = new Uniqueltem();
            Uniqueltem object3 = new Uniqueltem();
        }
    }
}
