namespace _03_Builder.Interfaces
{
    public interface IBuilder
    {
        void BuildMachineCase();
        void BuildWheels();
        void BuildEngine();
        void BuildSunroof();
        void BuildTintedWindows();
        void BuildSpoiler();
        ICar GetResult();
    }
}
