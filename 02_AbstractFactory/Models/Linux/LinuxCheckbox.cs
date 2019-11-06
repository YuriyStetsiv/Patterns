using _02_AbstractFactory.Interfaces.Models;
using System;

namespace _02_AbstractFactory.Models.Linux
{
    public class LinuxCheckbox : ICheckbox
    {
        public int ActiveItem { get; set; }
        public void SelecteItem()
        {
            Console.WriteLine($"Linux Checkbox selected item: {ActiveItem}!");
        }
    }
}
