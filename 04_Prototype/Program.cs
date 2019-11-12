using _04_Prototype.Models;
using System;

namespace _04_Prototype.Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IFigure figure = new Circle(10);
            IFigure figureClone = figure.Clone();

            GetInfo(figure,figureClone);

            figure = new Rectangle(4, 5);
            figureClone = figure.Clone();

            GetInfo(figure, figureClone);

            figure = new Square(5);
            figureClone = figure.Clone();

            GetInfo(figure, figureClone);

            figure = new Triangle(5,8,4);
            figureClone = figure.Clone();

            GetInfo(figure, figureClone);
        }

        //Show resault
        static void GetInfo(IFigure figure, IFigure figureClone)
        {
            Console.WriteLine($"{figure.GetType().Name} original:");
            Console.WriteLine($"Area: {figure.Area()}");
            Console.WriteLine($"Peremiter: {figure.Perimeter()}");

            Console.WriteLine($"{figureClone.GetType().Name} clone:");
            Console.WriteLine($"Area: {figureClone.Area()}");
            Console.WriteLine($"Peremiter: {figureClone.Perimeter()}\n");
        }
    }
}
