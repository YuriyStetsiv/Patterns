using _03_Builder.Interfaces;
using System.Collections.Generic;

namespace _03_Builder.Models
{
    public class BmwCar : ICar
    {
        public BmwCar()
        {
            Name = "BMW x7";
            Details = new List<string>();
        }
        public string Name { get; set; }

        public List<string> Details { get; set; }
    }
}
