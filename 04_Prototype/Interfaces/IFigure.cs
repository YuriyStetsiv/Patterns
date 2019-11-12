namespace _04_Prototype.Interfaces
{
    public interface IFigure: IClone<IFigure>
    {
        double Area();
        double Perimeter();
    }
}
