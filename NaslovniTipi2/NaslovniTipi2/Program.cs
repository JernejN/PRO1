using System;

/*
  Izdelajte novo aplikacijo v kateri boste izpisovali naključno karto. Najprej si definirajte dva
naštevna tipa: Barva (lahko je srce, karo, pik in križ) in Vrednost (lahko je as, dvojka, trojka,
štirka,…, fant, dama ali kralj). Nato si v programu deklarirajte dve spremenljivki: eno tipa
Barva, drugo tipa Vrednost. Spremenljivki tipa Barva priredite naključno vrednost barve,
spremenljivki tipa Vrednost pa naključno vrednost. Izpišite obe vrednosti. Naključne
vrednosti spremenljivkam prirejamo s pomočjo razreda Random:
…..
Random r=new Random();
…..
int x=r.next(10); //x dobi naključno vrednost med 0 in 10 t.j. 0,1,2,3,4,5,6,7,8 ali 9
 */
namespace NaslovniTipi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int Barva = r.Next(4);
            int stevilka = r.Next(10);

            karte k = (karte)Barva;
            vrednost v = (vrednost)stevilka;

            Console.WriteLine("Karta je: " + k + " z vrednostjo " + v);
            Console.ReadLine();



        }
    }
}
