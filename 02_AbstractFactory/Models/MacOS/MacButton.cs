using _02_AbstractFactory.Interfaces.Models;
using System;

namespace _02_AbstractFactory.Models.MacOS
{
    public class MacButton : IButton
    {
        public void onClick()
        {
            Console.WriteLine("MacOS Button onClick!");
        }

        public void DoubleClick()
        {
            Console.WriteLine("MacOS Button DoubleClick!");
        }
    }
}
