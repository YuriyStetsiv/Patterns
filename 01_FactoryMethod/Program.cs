using _01_FactoryMethod.Interfaces;
using System;

namespace _01_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IDialog dialog = null;

            Console.WriteLine("Enter your source (Windows or Html):");
            string oS = Console.ReadLine();

            switch (oS)
            {
                case "Html":
                    dialog = new WebDialog();
                    break;
                case "Windows":
                    dialog = new WindowsDialog();
                    break;

            }

            if (dialog is null)
                Console.WriteLine("Error!");
            else
                dialog.render();
        }
    }
}
