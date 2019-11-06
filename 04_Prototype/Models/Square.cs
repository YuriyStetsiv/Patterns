using _04_Prototype.Interfaces;

namespace _04_Prototype.Models
{
    public class Square : IFigure
    {
        private double _side;

        public Square(double side)
        {
            _side = side;
        }
        public double Area()
        {
            return _side * _side;
        }

        public double Peremiter()
        {
            return 4 * _side;
        }
        public IFigure Clone()
        {
            return new Square(_side);
        }
    }
}
