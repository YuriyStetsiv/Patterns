using _07_Bridge.Models.Languages;
using _07_Bridge.Models.Programmers;

namespace _07_Bridge
{
    class Program
    {
        static void Main()
        {
            Programmer programmer = new FreelanceProgrammer(new CSharpLanguage()); 
            //Programmer programmer = new CorporateProgrammer(new CSharpLanguage());
            
            programmer.DoWork();
            programmer.EarnMoney();

            programmer.ChangeLanguage(new CppLanguage());

            programmer.DoWork();
            programmer.EarnMoney();
        }
    }
}
