using System;
/*
 * Napišite program v katerem generirate 100 naključnih števil med 0 in 99, nato pa
izpišete vsoto teh sto števil.
 */
namespace VajaZanke2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int v = 0;
            for (int i = 0; i < 100; i++)
            {
                int s = r.Next(100);
                v = v + s;
            }
            Console.WriteLine("Vsota vseh stevil je :" + v);
            Console.ReadLine();
        }
    }
}
