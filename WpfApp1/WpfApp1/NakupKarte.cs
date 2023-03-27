using System;

namespace WpfApp1
{
    enum privilageLevel { Standard, Premium, Executive, PremiumExecutive };
    internal class NakupKarte
    {
        string imeDogodka;
        string stKupca;
        int stVstopnic;
        privilageLevel privilegij;

        public string StKupca
        {
            get => stKupca;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Ni Kupca");
                }
                else
                {
                    StKupca = value;
                }
            }
        }
    }
}
