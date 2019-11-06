using _02_AbstractFactory.Interfaces;
using _02_AbstractFactory.Interfaces.Models;
using _02_AbstractFactory.Models.MacOS;

namespace _02_AbstractFactory.Services
{
    public class MacFactory : IAbstractFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }
        public ICheckbox CreateCheckbox()
        {
            return new MacCheckbox();
        }
        public ITextbox CreateTextbox()
        {
            return new MacTextbox();
        }
    }
}
