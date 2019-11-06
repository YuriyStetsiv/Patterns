using _02_AbstractFactory.Interfaces.Models;
using System;

namespace _02_AbstractFactory.Models.MacOS
{
    public class MacTextbox : ITextbox
    {
        public string Text { get; set; }
        public void TextChange()
        {
            Console.WriteLine($"MacOS Textbox text change from {Text} to Default Text!");
        }
    }
}
