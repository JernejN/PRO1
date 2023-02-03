using System;
/*
 Izdelajte konzolno aplikacijo za izračun ocen, ki bo skladna z listo zahtevkov (stran 7 v skripti
   za Programiranje). Vnos podatkov naj bo omogočen prek tipkovnice (ne grafični vmesnik).
 */
namespace VajaIf5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Izberite predmet");
            string a = Console.ReadLine();
            int od = int.Parse(a);

            string t1, t2, t3, t4;
            int o1, o2, o3, o4;
            int pov = 0;


            switch (od)
            {
                case 1:
                    Console.WriteLine("ANG");
                    Console.WriteLine("Vpisite ocene");
                    t1 = Console.ReadLine();
                    t2 = Console.ReadLine();
                    t3 = Console.ReadLine();
                    t4 = Console.ReadLine();
                    o1 = int.Parse(t1);
                    o2 = int.Parse(t2);
                    o3 = int.Parse(t3);
                    o4 = int.Parse(t4);

                    pov = o1 + o2 + o3 + o4 / 4;
                    break;
                case 2:
                    Console.WriteLine("MAT");
                    Console.WriteLine("Vpisite ocene");
                    t1 = Console.ReadLine();
                    t2 = Console.ReadLine();
                    o1 = int.Parse(t1);
                    o2 = int.Parse(t2);

                    pov = o1 + o2 / 2;
                    break;
                case 3:
                    Console.WriteLine("NAR");
                    Console.WriteLine("Vpisite oceno");
                    t1 = Console.ReadLine();
                    o1 = int.Parse(t1);
                    pov = o1;
                    break;
            }
            if (93 >= pov)
            {
                Console.WriteLine("Ocena je A");
            }
            else if (pov >= 85 || pov <= 93)
            {
                Console.WriteLine("Ocena je B");
            }
            else if (pov >= 78 || pov <= 85)
            {
                Console.WriteLine("Ocena je C");
            }
            else if (pov >= 70 || pov <= 78)
            {
                Console.WriteLine("Ocena je D");
            }
            else if (pov <= 70)
            {
                Console.WriteLine("Ocena je F");
            }
        }
    }
}
