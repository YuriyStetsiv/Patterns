using _04_Prototype.Interfaces;

namespace _04_Prototype.Models
{
    public class Triangle : IFigure
    {
        double _sideA;
        double _sideB;
        double _sideC;

        public Triangle(double a, double b, double c)
        {
            _sideA = a;
            _sideB = b;
            _sideC = c;
        }

        public double Area()
        {
            double p = (_sideA + _sideB + _sideC) / 2;
            double res = System.Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));

            return res;
        }

        public double Peremiter()
        {
            return _sideC + _sideB + _sideA;
        }

        public IFigure Clone()
        {
            return new Triangle(_sideA, _sideB, _sideC);
        }
    }
}
