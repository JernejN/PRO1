using System;
/*
 * Napišite program v katerem generirate 1.000 naljučnih števil med 0 in 999, izpišite
povprečno vrednost naključno generiranih števil. 
 */
namespace VajaZanke3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int v = 0;
            double d = 0;
            for (int i = 0; i < 1000; i++)
            {
                int s = r.Next(1000);
                v = v + s;
            }
            d = v / 1000.0;
            Console.WriteLine("Povprečje je: " + d);
            Console.ReadLine();
        }
    }
}
