using _06_Adapter.Interfaces;

namespace _06_Adapter
{
    public class AnimalToTransportAdapter : ITransport
    {
        private readonly IAnimal _animal;

        public AnimalToTransportAdapter(IAnimal animal)
        {
            _animal = animal;
        }

        public void Drive()
        {
            _animal.Move();
        }
    }
}
