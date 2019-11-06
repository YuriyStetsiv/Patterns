using _02_AbstractFactory.Interfaces;
using _02_AbstractFactory.Services;
using System;

namespace _02_AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IAbstractFactory factory = null;
            
            Console.WriteLine("Windows | Mac | Linux");
            Console.Write("Enter your OS:");
            string oS = Console.ReadLine();

            switch (oS)
            {
                case "Windows":
                    factory = new WindowsFactory();
                    break;
                case "Linux":
                    factory = new LinuxFactory();
                    break;
                case "Mac":
                    factory = new MacFactory();
                    break;
            }

            if (factory != null)
            {
                var button = factory.CreateButton();
                var textbox = factory.CreateTextbox();
                var checkbox = factory.CreateCheckbox();

                Console.WriteLine("\nButton functional:");
                button.onClick();
                button.DoubleClick();

                Console.WriteLine("\nTextbox functional:");
                textbox.Text = "Test text!";
                textbox.TextChange();

                Console.WriteLine("\nCheckbox functional:");
                checkbox.ActiveItem = 1;
                checkbox.SelecteItem();
            }
            else { Console.WriteLine("Invalid OS!"); }
        }
    }
}
