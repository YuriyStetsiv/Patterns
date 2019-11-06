using _02_AbstractFactory.Interfaces.Models;
using System;

namespace _02_AbstractFactory.Models.Windows
{
    public class WindowsButton : IButton
    {
        public void onClick()
        {
            Console.WriteLine("Windows button onClick!");
        }

        public void DoubleClick()
        {
            Console.WriteLine("Windows button DoubleClick!");
        }
    }
}
