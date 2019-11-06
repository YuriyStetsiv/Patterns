using _04_Prototype.Models;
using System;

namespace _04_Prototype.Interfaces
{
    class Program
    {
        private static IFigure figure;
        private static IFigure figureClone;

        static void Main(string[] args)
        {
            figure = new Circle(10);
            figureClone = figure.Clone();

            GetInfo("Circle");

            figure = new Rectangle(4, 5);
            figureClone = figure.Clone();

            GetInfo("Rectangle");

            figure = new Square(5);
            figureClone = figure.Clone();

            GetInfo("Square");

            figure = new Triangle(5,8,4);
            figureClone = figure.Clone();

            GetInfo("Triangle");
        }

        //Show resault
        static void GetInfo(string figureName)
        {
            Console.WriteLine($"{figureName} original:");
            Console.WriteLine($"Area: {figure.Area()}");
            Console.WriteLine($"Peremiter: {figure.Peremiter()}");

            Console.WriteLine($"{figureName} clone:");
            Console.WriteLine($"Area: {figureClone.Area()}");
            Console.WriteLine($"Peremiter: {figureClone.Peremiter()}\n");
        }
    }
}
