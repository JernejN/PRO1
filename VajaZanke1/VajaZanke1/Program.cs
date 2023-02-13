using System;
/*
 Napišite program s pomočjo katerega uporabnik vnese 10 števil, nato pa izpišite
najmanjšega med njimi. 

 */
namespace VajaZanke1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = 10000;
            for (int n = 0; n < 10; n++)
            {
                int st = int.Parse(Console.ReadLine());
                if (st < min)
                {
                    min = st;
                }
            }
            Console.WriteLine("Min je: " + min);
            Console.ReadLine();
        }
    }
}
