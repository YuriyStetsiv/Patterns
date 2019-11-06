using _02_AbstractFactory.Interfaces;
using _02_AbstractFactory.Interfaces.Models;
using _02_AbstractFactory.Models.Linux;

namespace _02_AbstractFactory.Services
{
    public class LinuxFactory : IAbstractFactory
    {
        public IButton CreateButton()
        {
            return new LinuxButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new LinuxCheckbox();
        }

        public ITextbox CreateTextbox()
        {
            return new LinuxTexbox();
        }

    }
}
