using System;
using _07_Bridge.Models.Interfaces;

namespace _07_Bridge.Models.Programmers
{
    public class FreelanceProgrammer : Programmer
    {
        public FreelanceProgrammer(ILanguage lang) : base(lang)
        {
        }
        public override void EarnMoney()
        {
            Console.WriteLine("Get money after order completion.");
        }
    }
}
