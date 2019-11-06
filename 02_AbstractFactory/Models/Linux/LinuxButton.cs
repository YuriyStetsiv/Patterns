using _02_AbstractFactory.Interfaces.Models;
using System;

namespace _02_AbstractFactory.Models.Linux
{
    public class LinuxButton : IButton
    {
        public void onClick()
        {
            Console.WriteLine("Linux button onClick!");
        }

        public void DoubleClick()
        {
            Console.WriteLine("Linux button DoubleClick!");
        }
    }
}
