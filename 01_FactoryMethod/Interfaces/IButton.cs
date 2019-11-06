namespace _01_FactoryMethod.Interfaces
{
    // Патерн Фабричний метод має сенс лише тоді, коли в програмі є
    // ієрархія класів продуктів.
    public interface IButton
    {
        void render();
        void onClick();
    }
}
