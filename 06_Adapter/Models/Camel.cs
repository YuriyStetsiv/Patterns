using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _06_Adapter.Interfaces;

namespace _06_Adapter.Models
{
    public class Camel : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("Camel move!");
        }
    }
}
