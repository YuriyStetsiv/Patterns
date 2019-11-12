using _04_Prototype.Interfaces;

namespace _04_Prototype.Models
{
    public class Square : IFigure
    {
        private readonly double _side;

        public Square(double side)
        {
            _side = side;
        }
        public double Area()
        {
            return _side * _side;
        }

        public double Perimeter()
        {
            return 4 * _side;
        }
        public IFigure Clone()
        {
            return new Square(_side);
        }
    }
}
