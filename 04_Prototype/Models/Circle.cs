using _04_Prototype.Interfaces;
using System;

namespace _04_Prototype.Models
{
    public class Circle : IFigure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        public double Perimeter()
        {
            return 2 * Math.PI * _radius;
        }

        public IFigure Clone()
        {
            return new Circle(_radius);
        }
    }
}
