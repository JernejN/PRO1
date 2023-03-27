using System;

namespace Sprehod
{
    internal class Soba : Lokacija
    {
        private string dekoracija;
        public Soba(string i, string d) : base(i)
        {
            dekoracija = d;
        }
        public new void Opis()
        {
            base.Opis();
            Console.WriteLine("Vidiš " + dekoracija);
        }

    }
}
