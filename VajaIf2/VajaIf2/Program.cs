using System;
/*
Izdelajte program, s pomočjo katerega boste računali števke v trimestnem številu. Uporabnik
naj vnese poljubno 3-mestno število, nato naj program določi posamezno števko v številu. Če
so vse tri števke sode, naj se na zaslon izpiše »Števke so sode«. Če so vse tri števke lihe, naj
se na zaslon izpiše »Števke so lihe«, sicer naj se na zaslon izpiše »Števke so sode in lihe«.
 */
namespace VajaIf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int t = int.Parse(s);
            int za = t;

            int s1 = za % 10;
            za = za / 10;
            int s2 = za % 10;
            za = za / 10;
            int s3 = za % 10;

            Console.WriteLine("stevilo je bilo " + t);

            if (s1 % 2 == 0 && s2 % 2 == 0 && s3 % 2 == 0)
            {
                Console.WriteLine("Stevke so sode");

            }
            else if (s1 % 2 != 0 && s2 % 2 != 0 && s3 % 2 != 0)
            {
                Console.WriteLine("Stevke so lihe");

            }
            else if (s1 % 2 != 0 || s2 % 2 != 0 || s3 % 2 != 0 || s1 % 2 != 0 && s2 % 2 != 0 && s3 % 2 != 0)
            {
                Console.WriteLine("Stevke so lihe in sode");
            }

        }

    }
}
