using _03_Builder.Interfaces;
using _03_Builder.Models;
using System;

namespace _03_Builder
{
    class Program
    {
        static IBuilder builder;

        static void Main(string[] args)
        {
            Console.WriteLine("BMW | Mercedes");
            Console.Write("Enter car name:");
            string carName = Console.ReadLine();
            switch(carName.ToLower())
            {
                case "bmw":
                    builder = new CarBuilder( new BmwCar());
                    break;
                case "mercedes":
                    builder = new CarBuilder(new MercedesCar());
                    break;
                default:
                    Console.WriteLine("Not correct input!");
                    System.Environment.Exit(1);
                    break;
            }
   
            Director director = new Director(builder);

            Console.WriteLine("Luxury | Simple");
            Console.Write("Enter class of car:");
            string carClass = Console.ReadLine();          
            switch(carClass.ToLower())
            {
                case "luxury":
                    director.ConstructLuxuryCar();
                    break;
                case "simple":
                    director.ConstructBaseCar();
                    break;
                default:
                    Console.WriteLine("Not correct input!");
                    System.Environment.Exit(1);
                    break;
            }

            // The Builder pattern can be used without a Director class.
            Console.WriteLine($"Car name: {builder.GetResult().Name}");
            Console.WriteLine("Car details:");
            foreach (var det in builder.GetResult().Details)
            {
                Console.WriteLine(det);
            }
        }
    }
}
