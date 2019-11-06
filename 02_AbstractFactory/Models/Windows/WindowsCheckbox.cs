using _02_AbstractFactory.Interfaces.Models;
using System;

namespace _02_AbstractFactory.Models.Windows
{
    public class WindowsCheckbox : ICheckbox
    {
        public int ActiveItem { get; set; }

        public void SelecteItem()
        {
            Console.WriteLine($"Windows Checkbox selected item: {ActiveItem}!");
        }
    }
}
