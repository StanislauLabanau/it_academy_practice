using System;
using System.Collections.Generic;

namespace Square
{
    class GeoFigure
    {
        public string Name { get; private set; }
        public double MainParametr { get; private set; }

        public GeoFigure(string name, double param)
        {
            Name = name;
            if (param >= 1 && param <= 10) MainParametr = param;

            else Console.WriteLine("the value is wrong");

        }

        public virtual void ShowResult()
        {
            Console.Write($"This is {Name}. It's type is {this.GetType()}. It's squere is ");
        }
    }

    class Circle : GeoFigure
    {
        public Circle(string name, double radius) : base(name, radius) { }
        public override void ShowResult()
        {
            base.ShowResult();
            Console.WriteLine(Math.PI * MainParametr * MainParametr);
        }
    }

    class Square : GeoFigure
    {
        public Square(string name, double side) : base(name, side) { }
        public override void ShowResult()
        {
            base.ShowResult();
            Console.WriteLine(MainParametr * MainParametr);
        }
    }

    class Triangle : GeoFigure
    {
        public double Higth { get; private set; }

        public Triangle(string name, double basis, double higth) : base(name, basis)
        {
            if (higth >= 1 && higth <= 10) Higth = higth;

            else Console.WriteLine("the value is wrong");
        }

        public override void ShowResult()
        {
            base.ShowResult();
            Console.WriteLine(MainParametr * Higth / 2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<GeoFigure> geoFigures = new List<GeoFigure>();
            geoFigures.Add(new Circle("Circle 3", 1.5));
            geoFigures.Add(new Circle("Circle 5", 2.5));
            geoFigures.Add(new Square("Square 3", 3));
            geoFigures.Add(new Square("Square 5", 5));
            geoFigures.Add(new Triangle("Triangle", 3, 5));

            foreach(GeoFigure geoFigure in geoFigures)
            {
                geoFigure.ShowResult();
            }

            Console.Read();
        }
    }
}
