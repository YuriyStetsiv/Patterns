using _02_AbstractFactory.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AbstractFactory.Models.Windows
{
    public class WindowsTextbox : ITextbox
    {
        public string Text { get; set; }

        public void TextChange()
        {
            Console.WriteLine($"Windows Textbox text change from {Text} to Default Text!");
        }
    }
}
