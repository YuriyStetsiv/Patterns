using System;
using _07_Bridge.Models.Interfaces;

namespace _07_Bridge.Models.Programmers
{
    public class CorporateProgrammer : Programmer
    {
        public CorporateProgrammer(ILanguage lang) : base(lang)
        {

        }
        public override void EarnMoney()
        {
            Console.WriteLine("Get money at the end of the month.");
        }
    }
}
