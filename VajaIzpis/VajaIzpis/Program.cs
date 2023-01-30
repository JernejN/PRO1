using System;

namespace VajaIzpis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 20;
            double b = -13.6667;
            double c = 17;
            double d = 12.88;
            double e = 2222.879;
            Console.WriteLine("a={0,20:f2}", a);
            Console.WriteLine("b={0,20:f2}", b);
            Console.WriteLine("c={0,20:f2}", c);
            Console.WriteLine("d={0,20:f2}", d);
            Console.WriteLine("e={0,20:f2}", e);

            char znak = '?';
            int ascii = znak;
            Console.WriteLine("? ima ascii kodo: " + ascii);

            int asciib = 65;
            char znakb = (char)asciib;
            Console.WriteLine("koda 69: " + znakb);


        }
    }
}
