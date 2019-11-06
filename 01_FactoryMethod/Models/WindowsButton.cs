using System;
using _01_FactoryMethod.Interfaces;

namespace _01_FactoryMethod.Models
{
    public class WindowsButton:IButton
    {
        public void render()
        {
            Console.WriteLine("Windows button render!");
        }
        public void onClick()
        {
            Console.WriteLine("Windows button click!");
        }
    }
}
