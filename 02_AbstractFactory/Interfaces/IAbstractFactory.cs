using _02_AbstractFactory.Interfaces.Models;

namespace _02_AbstractFactory.Interfaces
{
    public interface IAbstractFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
        ITextbox CreateTextbox();
    }
}
