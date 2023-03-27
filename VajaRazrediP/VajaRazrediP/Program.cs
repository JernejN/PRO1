using System;

namespace VajaRazrediP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Palice p = new Palice();
            while (!p.Konec())
            {
                p.IzpisStanja();
                Console.WriteLine("Koliko stevilo palic vzames?");
                int x = int.Parse(Console.ReadLine());
                p.VzemPalic(x);
            }
            Console.WriteLine("Zmagovalec je igralec " + p.Zmagovalec());
            Console.ReadLine();

        }
    }
}
