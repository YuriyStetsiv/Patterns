using _02_AbstractFactory.Interfaces;
using _02_AbstractFactory.Interfaces.Models;
using _02_AbstractFactory.Models.Windows;

namespace _02_AbstractFactory.Services
{
    public class WindowsFactory : IAbstractFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new WindowsCheckbox();
        }
        public ITextbox CreateTextbox()
        {
            return new WindowsTextbox();
        }

    }
}
