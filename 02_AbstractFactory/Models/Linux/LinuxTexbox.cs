using _02_AbstractFactory.Interfaces.Models;
using System;

namespace _02_AbstractFactory.Models.Linux
{
    public class LinuxTexbox : ITextbox
    {
        public string Text { get; set; }

        public void TextChange()
        {
            Console.WriteLine($"Linux Textbox text change from {Text} to Default Text!");
        }
    }
}
