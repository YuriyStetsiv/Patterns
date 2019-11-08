using _03_Builder.Interfaces;

namespace _03_Builder
{
    public class Director
    {
        private readonly IBuilder _builder;
        public Director(IBuilder builder)
        {
            this._builder = builder;
        }
        public void ConstructBaseCar()
        {
            _builder.BuildMachineCase();
            _builder.BuildWheels();
            _builder.BuildEngine();
        }

        public void ConstructLuxuryCar()
        {
            ConstructBaseCar();

            _builder.BuildSpoiler();
            _builder.BuildSunroof();
            _builder.BuildTintedWindows();
        }
    }
}