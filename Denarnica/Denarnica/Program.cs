using System;

namespace Denarnica
{
    public class Banka
    {
        public int stLet;
        public double glavnica, obrestnaMera;

        public Banka(int stLet, double glavnica, double obrestnaMera)
        {
            this.stLet = stLet;
            this.obrestnaMera = obrestnaMera;
            this.glavnica = glavnica;
        }

        public double dnevneObresti()
        {
            return glavnica * Math.Pow(1 + (obrestnaMera), stLet * 365);
        }

        public double letneObresti()
        {
            return glavnica * Math.Pow(1 + (obrestnaMera / 365), stLet);
        }


        static void Main(string[] args)
        {
            Banka b1 = new Banka(6, 1200, 0.1);
            Console.WriteLine("Letne Obresti: " + b1.letneObresti());

            Console.WriteLine("Dnevne Obresti: " + b1.dnevneObresti());
        }
    }
}
