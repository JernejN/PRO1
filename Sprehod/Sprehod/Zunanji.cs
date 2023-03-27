using System;

namespace Sprehod
{
    internal class Zunanji : Lokacija
    {
        bool jeVroče;
        public Zunanji(string i, bool v) : base(i)
        {
            jeVroče = v;
        }
        public string Opis()
        {
            string r = base.Opis();
            r += Environment.NewLine;
            r += "Je vroče? " + jeVroče + Environment.NewLine;
            return r;
        }
    }
}
