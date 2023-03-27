using System;

namespace Vaja2022_1
{
    internal class Metalec : Atlet
    {
        string imeDiscipline;
        double[] meti = new double[6];

        public Metalec(int s, string p, string i, string k, string imeD) : base(s, p, i, k)
        {
            imeDiscipline = imeD;
        }
        public override void vnesiRezultat()
        {
            for (int k = 0; k < 6; k++)
            {
                Console.WriteLine("Vnesi rezultat meta:  " + (k + 1) + ": ");
                meti[k] = double.Parse(Console.ReadLine());
            }
        }
        public new void Izpis()
        {
            base.Izpis();
            for (int k = 0; k < 6; k++)
            {
                Console.Write(meti[k] + "\t");
            }
        }
        public double NajbolšiMet()
        {
            double max = 0;
            for (int k = 0; k < 6; k++)
            {
                if (max < meti[k])
                {
                    max = meti[k];
                }
            }
            return max;
        }
    }
}
