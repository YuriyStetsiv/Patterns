namespace _02_AbstractFactory.Interfaces.Models
{
    public interface ICheckbox
    {
        int ActiveItem { get; set; }
        void SelecteItem();
    }
}
