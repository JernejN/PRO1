using System;

namespace VajaAbstraktK
{
    /*
     Gradite aplikacijo za upravljanje zalog v trgovini. Na voljo sta dve vrsti izdelkov: knjige in
igrače. Obe vrsti izdelkov morata imeti edinstven ID, ime in ceno. Razred Knjiga in razred
Igrača morata dedovati od abstraktnega razreda AbstractProduct, ki implementira vmesnik
IProduct. Vmesnik IProduct mora definirati naslednje metode:
 GetID(): vrne ID izdelka.
 GetName(): vrne ime izdelka.
 GetPrice(): vrne ceno izdelka.
Abstraktni razred AbstractProduct mora implementirati vmesnik IProduct in definirati
naslednje abstraktne metode:
GetDescription(): vrne opis izdelka.
GetDiscountedPrice(): vrne ceno izdelka po uporabi morebitnih popustov.
Razreda Knjiga in Igrača morata imeti metodi GetDescription() in GetDiscountedPrice(),
medtem ko mora razred AbstractProduct definirati metodo GetCategory(), ki vrne kategorijo
izdelka (bodisi "knjiga" ali "igrača").
V metodi Main testirajte delovanje.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Igraca a = new Igraca(1, "Žoga", 5.6);
            Console.WriteLine(a.GetIme() + " " + a.GetCategory());
            Console.WriteLine(a.GetDescription());
            Console.WriteLine(a.GetPrice() + " " + a.GetDiscountedPrice());

            Knjiga b = new Knjiga(2, "Millenium", 35.3);
            Console.WriteLine(a.GetIme() + " " + a.GetCategory());
            Console.WriteLine(a.GetDescription());
            Console.WriteLine(a.GetPrice() + " " + a.GetDiscountedPrice());

            Console.ReadLine();


        }
    }
}
