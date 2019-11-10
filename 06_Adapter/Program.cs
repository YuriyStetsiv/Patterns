using System;
using _06_Adapter.Models;

namespace _06_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new Driver();
            
            var car = new Car();

            driver.Travel(car);

            var camel = new Camel();
            
            var camelTransport = new AnimalToTransportAdapter(camel);
            
            driver.Travel(camelTransport);
        }
    }
}
