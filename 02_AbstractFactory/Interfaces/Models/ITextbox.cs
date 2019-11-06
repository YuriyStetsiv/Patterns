namespace _02_AbstractFactory.Interfaces.Models
{
    public interface ITextbox
    {
        string Text { get; set; }
        void TextChange();
    }
}
