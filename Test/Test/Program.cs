namespace Prvi
{

    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            /* stanje*/
            Console.WriteLine("Vnesite začetno stanje:");
            int stanje = int.Parse(Console.ReadLine());

            /* stanje*/
            Console.WriteLine("Vnesite začetno stavo: ");
            int stava = int.Parse(Console.ReadLine());
            int zacStava = stava;
            int zacetno = stanje;
            int minStanje = stanje;

            for (int i = 0; i < 10; i++)
            {
                int st = random.Next(1, 37);
                if (st % 2 == 0)
                {
                    stanje += stava;
                    Console.WriteLine("ZADETEK! Stanje se je povečalo na " + stanje);

                    stava = zacStava;
                }
                else
                {

                    stanje -= stava;
                    Console.WriteLine("Žal niste zadeli, trenutno stanje je " + stanje);
                    stava = stava * 2;
                }
                if (minStanje <= stanje) minStanje = stanje;

            }
            Console.WriteLine("Igro ste začeli z " + zacetno + "€ in končali z " + stanje + "€, pri tem ste zaslužili " + (stanje - zacetno));
            Console.WriteLine("Maksimalno stanje je bilo " + stanje + "€ minimalno pa " + minStanje + "€");
        }
    }
}

