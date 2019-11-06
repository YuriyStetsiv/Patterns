using System;

namespace _05_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.GetInstance();

            singleton.SomeBuisnessLogic();
        }
    }

}
