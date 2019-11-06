using System;

namespace _05_Singleton
{
    public class Singleton
    {
        private static Singleton _instance;

        // The Singleton's constructor should always be private to prevent
        // direct construction calls with the `new` operator.
        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        public void SomeBuisnessLogic()
        {
            Console.WriteLine("Some buisness logic...");
        }
    }
}
