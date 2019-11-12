using _04_Prototype.Interfaces;

namespace _04_Prototype.Models
{
    public class Rectangle : IFigure
    {
        private readonly double _sideA;
        private readonly double _sideB;

        public Rectangle(double a, double b)
        {
            _sideA = a;
            _sideB = b;
        }

        public double Area()
        {
            return _sideA * _sideB;
        }

        public double Perimeter()
        {
            return 2 * _sideA + 2 * _sideB;
        }

        public IFigure Clone()
        {
            return new Rectangle(_sideA, _sideB);
        }
    }
}
