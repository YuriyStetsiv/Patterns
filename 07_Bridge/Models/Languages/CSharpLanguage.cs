using System;
using _07_Bridge.Models.Interfaces;

namespace _07_Bridge.Models.Languages
{
    public class CSharpLanguage : ILanguage
    {
        public void Build()
        {
            Console.WriteLine("Roslyn compiles the source code in .exe file.");
        }

        public void Execute()
        {
            Console.WriteLine("JIT compiles the program in binary code.");
            Console.WriteLine("CLR run code.");
        }
    }
}
