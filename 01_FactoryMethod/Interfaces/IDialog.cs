namespace _01_FactoryMethod.Interfaces
{
    //Можливо куди доцільніше використовувати abstract class
    public interface IDialog
    {
        // Програма створює певний екземпляр в залежності від
        // конфігурації або оточення.
        void render()
        {
            IButton button = createButton();
            
            button.render();
            button.onClick();
        }

        IButton createButton();
    }
}
