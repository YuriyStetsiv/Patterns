using System;
using _06_Adapter.Interfaces;

namespace _06_Adapter.Models
{
    public class Car : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("Car drive!");
        }
    }
}
