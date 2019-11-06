using _04_Prototype.Interfaces;

namespace _04_Prototype.Models
{
    public class Rectangle : IFigure
    {
        private double _sideA;
        private double _sideB;

        public Rectangle(double a, double b)
        {
            _sideA = a;
            _sideB = b;
        }

        public double Area()
        {
            return _sideA * _sideB;
        }

        public double Peremiter()
        {
            return 2 * _sideA + 2 * _sideB;
        }

        public IFigure Clone()
        {
            return new Rectangle(_sideA, _sideB);
        }
    }
}
