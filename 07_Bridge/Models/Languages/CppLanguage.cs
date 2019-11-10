using System;
using _07_Bridge.Models.Interfaces;

namespace _07_Bridge.Models.Languages
{
    public class CppLanguage : ILanguage
    {
        public void Build()
        {
            Console.WriteLine("C++ compiles the program in binary code.");
        }

        public void Execute()
        {
            Console.WriteLine("Run .exe file.");
        }
    }
}
