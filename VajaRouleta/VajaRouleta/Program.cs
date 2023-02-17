using System;

namespace VajaRouleta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.WriteLine("Vnesi začetni denarni vložek");
            int stanje = int.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi začetno stavo");
            int stava = int.Parse(Console.ReadLine());
            int zacstanje = stanje;
            int zacstava = stava;
            int min = 10000;
            int max = 0;
            int m = 0;
            string barva = "";
            for (int i = 1; i <= 10; i++)
            {
                m = r.Next(36);
                if (m % 2 == 0 && m != 0)
                {
                    stanje = stanje + stava;
                    stava = zacstava;
                    barva = "rdeča";

                }
                else
                {
                    stanje = stanje - stava;
                    stava = stava * 2;
                    barva = "črna";

                }

                if (stanje < min)
                {
                    min = stanje;
                }
                if (stanje > max)
                {
                    max = stanje;
                }
                Console.WriteLine("Met: " + i + " Barva: " + barva + " stanje " + stanje);
            }
            int razlika = stanje - zacstanje;
            Console.WriteLine("Stevilo metov: " + 10);
            Console.WriteLine("začetno stanje: " + zacstanje);
            Console.WriteLine("Končnio stanje: " + stanje);
            Console.WriteLine("Najvišje stanej: " + max);
            Console.WriteLine("Najnižje stanej: " + min);
            Console.WriteLine("Razlika med stanji: " + razlika);
            Console.ReadLine();
        }
    }
}
