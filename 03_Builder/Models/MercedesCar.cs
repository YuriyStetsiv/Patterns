using _03_Builder.Interfaces;
using System.Collections.Generic;

namespace _03_Builder.Models
{
    public class MercedesCar : ICar
    {
        public MercedesCar()
        {
            Name = "Mercedes Benz s600";
            Details = new List<string>();
        }

        public string Name { get; set; }

        public List<string> Details { get; set; }
    }
}
