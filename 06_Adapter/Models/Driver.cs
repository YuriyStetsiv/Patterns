using _06_Adapter.Interfaces;

namespace _06_Adapter.Models
{
    public class Driver
    {
        public void Travel(ITransport transport)
        {
            transport.Drive();
        }
    }
}
