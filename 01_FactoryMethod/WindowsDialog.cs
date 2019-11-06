using _01_FactoryMethod.Interfaces;
using _01_FactoryMethod.Models;

namespace _01_FactoryMethod
{
    public class WindowsDialog : IDialog
    {
        public IButton createButton()
        {
            return new WindowsButton();
        }
    }
}
