
using System;

namespace Vaja2022_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metalec m = new Metalec(1, "Kozmus", "Primož", "Ilirija", "Met kladiva");
            m.vnesiRezultat();
            m.Izpis();
            Console.WriteLine("Najdaljši met " + m.NajbolšiMet());
            Console.ReadLine();
        }
    }
}
