using System;

namespace Sprehod
{
    internal class Program
    {
        static Soba dnevnaSoba;
        static Soba Kuhinja;
        static Soba Jedilnica;
        static Zunanji vrt;
        static Zunanji sprednje;
        static Zunanji zadnje;
        static Lokacija TrentnaPozicija;
        static void PremakniSe(Lokacija novaLokacija)
        {
            TrentnaPozicija = novaLokacija;
            Console.WriteLine(TrentnaPozicija.Opis());
        }
        static void Main(string[] args)
        {
            UstvariHišo();
            TrentnaPozicija = dnevnaSoba;
            PremakniSe(dnevnaSoba);
            string odg = "";
            while (odg != "k")
            {
                Console.WriteLine("Kam naj grem? K=konec");
                odg = Console.ReadLine();
                Lokacija nova = null;
                if (odg.ToUpper() == "K")
                {
                    Console.WriteLine("Lep sprehod");
                    Console.ReadLine();
                }
                else
                {
                    int n = int.Parse(odg);
                    nova = new Lokacija(TrentnaPozicija.izhodi[n].ime);
                    switch (nova.ime)
                    {
                        case "Dnevna Soba":
                            nova = dnevnaSoba;
                            break;
                        case "Kuhinja":
                            nova = Kuhinja;
                            break;
                        case "Jedilnica":
                            nova = Jedilnica;
                            break;
                        case "Sprednje dvorišče":
                            nova = sprednje;
                            break;
                        case "Zadnje dvorišče":
                            nova = zadnje;
                            break;
                        case "vrt":
                            nova = vrt;
                            break;
                    }
                    PremakniSe(nova);
                }
            }
        }
        static void UstvariHišo()
        {
            dnevnaSoba = new Soba("Dnevna Soba", "Starinski tepih");
            Kuhinja = new Soba("Kuhinja", "Srebrn pribor");
            Jedilnica = new Soba("Jedilnica", "Lončen lonec");
            vrt = new Zunanji("vrt", false);
            sprednje = new Zunanji("Sprednje dvorišče", true);
            zadnje = new Zunanji("Zadnje dvorišče", false);

            dnevnaSoba.izhodi = new Lokacija[2];
            dnevnaSoba.izhodi[0] = sprednje;
            dnevnaSoba.izhodi[1] = Jedilnica;

            Kuhinja.izhodi = new Lokacija[2];
            Kuhinja.izhodi[0] = Jedilnica;
            Kuhinja.izhodi[1] = zadnje;

            Jedilnica.izhodi = new Lokacija[2];
            Jedilnica.izhodi[0] = dnevnaSoba;
            Jedilnica.izhodi[1] = Kuhinja;

            vrt.izhodi = new Lokacija[2];
            vrt.izhodi[0] = sprednje;
            vrt.izhodi[1] = zadnje;

            sprednje.izhodi = new Lokacija[2];
            sprednje.izhodi[0] = dnevnaSoba;
            sprednje.izhodi[1] = vrt;

            zadnje.izhodi = new Lokacija[2];
            zadnje.izhodi[0] = vrt;
            zadnje.izhodi[1] = Kuhinja;
        }
    }
}
