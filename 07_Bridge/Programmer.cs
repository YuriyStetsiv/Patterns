using _07_Bridge.Models.Interfaces;

namespace _07_Bridge
{
    public abstract class Programmer
    {
        //!!!
        private protected ILanguage _language;

        protected Programmer(ILanguage language)
        {
            _language = language;
        }

        public void ChangeLanguage(ILanguage language)
        {
            if (language != null)
            {
                _language = language;
            }
        }

        public virtual void DoWork()
        {
            _language.Build();
            _language.Execute();
        }
        public abstract void EarnMoney();
    }
}
