using System;
/*
 Izdelajte si novo aplikacijo. V programu boste beležili klice iz mobilnega telefona in
izračunavali dolg stranke.
Najprej si deklarirajte naštevni tip TipKlica, ki vsebuje dve vrednosti : KlicVMobilno,
KlicVStacionarno.
Nato vprašajte uporabnika za tip klica (shranite odgovor v spremenljivko tip) in za število
minut pogovora (shranite odgovor v spremenljivko minute.
Nato izračunajte in izpišite znesek, ki ga uporabnik dolguje : Za klice v mobilno omrežje, naj se
mu izračuna vrednost število minut * 0,03€, za klice v stacionarno pa število minut * 0,2€.
Program naj izpiše koliko uporabnik dolguje.
 */

namespace Nastevni_tipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Izberite tip klica: 1-mobilno, 2-stacionarno");
            string klic = Console.ReadLine();
            int tip = int.Parse(klic);
            Console.WriteLine("Vpišite stevilo minut pogovora");
            int minute = Convert.ToInt32(Console.ReadLine());
            if (tip.Equals(1))
            {

                double znesek = minute * 0.03;
                Console.WriteLine("Vaš zenesek je: " + znesek);
                Console.ReadLine();
            }
            else
            {
                double znesek = minute * 0.2;
                Console.WriteLine("Vaš zenesek je: " + znesek);
                Console.ReadLine();
            }
            /* Planeti p = Planeti.Zemlja;
            Console.WriteLine("Izbral sem: " + p);
            int odd = (int)p;
            Console.WriteLine("Po odaljeni od sonca je " + odd);
            Perioda pp = Perioda.Jupiter;
            if (pp <= Perioda.Mars)
            {
                Console.WriteLine("Odhodni čas je: " + (int)pp);
            }
            else
            {
                Console.WriteLine("Odhodni čas ni znan za: " + pp);
            }
            Console.WriteLine("Vnesi vsporedno stevilko tvojega meseca");
            String odg = Console.ReadLine();
            int mojplanet = int.Parse(odg);
            Planeti moj = (Planeti)mojplanet;
            Console.WriteLine("Thoj planet je: " + moj);
            Console.ReadLine(); */
        }
    }
}
