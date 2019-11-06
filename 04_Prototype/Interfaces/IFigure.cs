namespace _04_Prototype.Interfaces
{
    public interface IFigure
    {
        double Area();
        double Peremiter();

        //Prototype realization
        IFigure Clone();
    }
}
