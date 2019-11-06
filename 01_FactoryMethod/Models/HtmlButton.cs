using System;
using _01_FactoryMethod.Interfaces;

namespace _01_FactoryMethod.Models
{
    public class HtmlButton:IButton
    {
        public void render()
        {
            Console.WriteLine("Html button render!");
        }
        public void onClick()
        {
            Console.WriteLine("Html button click!");
        }
    }
}
