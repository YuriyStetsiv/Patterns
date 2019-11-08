using _03_Builder.Interfaces;

namespace _03_Builder
{
    public class CarBuilder : IBuilder
    {
        private readonly ICar _car;

        public CarBuilder(ICar car)
        {
            _car = car;
        }

        public void BuildMachineCase()
        {
            _car.Details.Add($"{_car.Name} Machine Case");
        }
        public void BuildWheels()
        {
            _car.Details.Add($"{_car.Name} Wheels");
        }
        public void BuildEngine()
        {
            _car.Details.Add($"{_car.Name} Engine");
        }
        public void BuildSunroof()
        {
            _car.Details.Add("Sunroof");
        }
        public void BuildTintedWindows()
        {
            _car.Details.Add("Tinted windows");
        }
        public void BuildSpoiler()
        {
            _car.Details.Add("Spoiler"); ;
        }
        public ICar GetResult()
        {
            return _car;
        }
    }
}
