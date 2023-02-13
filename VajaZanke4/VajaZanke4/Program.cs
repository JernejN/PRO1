using System;
/*
 V programu generirajte 100.000 naključnih števil med o in 1.000.000. Denimo, da ta
števila predstavljajo zneske, ki jih imajo posamezniki na banki. Nato izračunajte vsoto
teh zneskov . Banka bi rada obračunala obresti ( letne 2,3%) na vsak posamezen
znesek, zanima jih pa tudi koliko bodo obresti obremenile banko. V ta namen
izračunajte koliko je 2,3% od vsote vseh zneskov in koliko je vsota obresti ( vsak
znesek pomnožite s 2,3% in jih nato seštejte).
 */
namespace VajaZanke4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float vz = 0;
            float vo = 0;
            Random r = new Random();
            for (int i = 0; i < 1000000; i++)
            {
                float z = r.Next(1000000);
                vz = vz + z;
                float o = z * 0.023f;
                vo = vo + o;
            }
            Console.WriteLine("Vsota zneskov *0.023 {0,15:n2}", vz * 0.023f);
            Console.WriteLine("Vsota obresti        {0,15:n2}", vo);
            Console.ReadLine();
        }
    }
}
