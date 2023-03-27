using System;

namespace VajaRazrediP
{
    internal class Palice
    {
        int stp;
        int igr;

        public int Stp { get => stp; }
        public int Igr { get => igr; }

        public Palice()
        {
            igr = 1;
            stp = 11;
        }
        public Palice(int s)
        {
            igr = 1;
            stp = s;

        }
        public Palice(int s, int i)
        {
            igr = i;
            stp = s;

        }
        public void IzpisStanja()
        {
            Console.WriteLine("Na mizi je " + stp);
            Console.WriteLine("Na vrsti je " + igr);
        }
        public void VzemPalic(int n)
        {
            if (n < 1 || n > 3)
            {
                Console.WriteLine("Napaka");
                return;
            }
            stp = stp - n;
            igr = 3 - igr;

        }
        public bool Konec()
        {
            return stp <= 0;
        }
        public int Zmagovalec()
        {
            return igr;

        }
    }
}
