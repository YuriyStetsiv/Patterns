using _02_AbstractFactory.Interfaces.Models;
using System;

namespace _02_AbstractFactory.Models.MacOS
{
    public class MacCheckbox : ICheckbox
    {
        public int ActiveItem { get; set; }

        public void SelecteItem()
        {
            Console.WriteLine($"MacOS Checkbox selected item: {ActiveItem}!");
        }
    }
}
