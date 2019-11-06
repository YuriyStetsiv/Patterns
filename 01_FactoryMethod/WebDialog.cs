using System;
using _01_FactoryMethod.Interfaces;
using _01_FactoryMethod.Models;

namespace _01_FactoryMethod
{
    public class WebDialog : IDialog
    {
        public IButton createButton()
        {
            return new HtmlButton();
        }
    }
}
