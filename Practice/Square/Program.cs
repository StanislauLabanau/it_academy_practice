using System;

namespace Square
{
    class GeoFigure
    {
        public string Name { get; private set; }
        public GeoFigure (string name)
        { Name = name; }
    }
    class Circle : GeoFigure
    {
        private int _radius;

        public int Radius
        {
            get { return _radius; }
            set
            {
                if (value >= 1 && value <= 10)
                    _radius = value;
                else
                    Console.WriteLine("wrong value");
            }
        }
        public Circle(string name, int radius): base(name)
        {
            Radius = radius;
        }
        public void ShowSquere()
        {
            Console.WriteLine($"This is {Name}. It's type is{this.GetType()}. Squere is{Math.PI*Radius*Radius}");
        }

        class Squere:GeoFigure
        {
            private int _side;

            public int Side
            {
                get { return _side; }
                set
                {
                    if (value >= 1 && value <= 10)
                        _side = value;
                    else
                        Console.WriteLine("wrong value");
                }
            }
            public Squere(string name, int side) : base(name)
            {
                Side =side;
            }
            public void ShowSquere()
            {
                Console.WriteLine($"This is {Name}. It's type is{this.GetType()}. Squere is{Side*Side}");
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
