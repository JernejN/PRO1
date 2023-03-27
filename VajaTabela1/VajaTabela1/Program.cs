using System;

namespace VajaTabela1
{
    /*
     Napišite program, v katerem imate deklarirano spremenljivko a, ki je tabela
cela števil. Vsebuje naj 10 elementov.
a. napišite kodo s pomočjo katere bo uporabnik vnesel 10 števil. Števila
shranite v tabelo a. Program naj uporabnika vpraša : "Vnesi število 1 ",
nato počaka na vnos, nato "Vnesi število 2 " itd.
b. napišite del kode, kjer boste poiskali in izpisali najmanjši in največji
element tabele
c. napišite kodo, kjer boste izračunali in izpisali vsoto in povprečno
vrednost elementov tabele. 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int max = 0;
            int min = 100000;
            int v = 0;
            int p = 0;
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Vnesi stevilo");
                a[i] = int.Parse(Console.ReadLine());
            }

            for (int m = 0; m < a.Length; m++)
            {
                if (a[m] < min)
                {
                    min = a[m];
                }
                if (a[m] > max)
                {
                    max = a[m];
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                v = v + a[i];
                p = v / 10;

            }
            Console.WriteLine("Max: " + max + " Min: " + min);
            Console.WriteLine("Vsota: " + v + " Povprečje: " + p);
            Console.ReadLine();
        }
    }
}
