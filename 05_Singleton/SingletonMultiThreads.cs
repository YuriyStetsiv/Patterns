using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Singleton
{
    public class SingletonMultiThreads
    {
        private SingletonMultiThreads() { }

        private static SingletonMultiThreads _instance;

        // We now have a lock object that will be used to synchronize threads
        // during first access to the Singleton.
        private static readonly object _lock = new object();

        public static SingletonMultiThreads GetInstance(string value)
        {
            if (_instance == null)
            {

                lock (_lock)
                {

                    if (_instance == null)
                    {
                        _instance = new SingletonMultiThreads();
                    }
                }
            }

            return _instance;
        }
    }
}
