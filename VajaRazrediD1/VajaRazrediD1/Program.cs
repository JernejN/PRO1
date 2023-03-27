using System;

namespace VajaRazrediD1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Oseba a = new Oseba("Miha", 19);
            Oseba b = new Oseba("Marija", 16);
            Console.WriteLine(a.Ime + " je polnoletna?" + a.IsAdult());
            Console.WriteLine(a.Ime + " je enaka osebi b?" + b.IsEqual());
        }
    }
}
