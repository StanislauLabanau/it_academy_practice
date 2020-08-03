using System;

namespace Lecture._12
{
    public class Uniqueltem
    {
        public static int IdSt = default;
        public int Id { get; set; }

        public Uniqueltem(int id)
        {
            Id = id;
            IdSt = id;
            IdSt++;
        }

        public Uniqueltem()
        {
            Id = IdSt;
            IdSt++;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Uniqueltem object1 = new Uniqueltem(2);
            Uniqueltem object2 = new Uniqueltem();
            Uniqueltem object3 = new Uniqueltem(10);
        }
    }
}
