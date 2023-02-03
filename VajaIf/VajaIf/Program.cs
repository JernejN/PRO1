using System;

/*
Izdelajte novo konzolno aplikacijo z imenom Vaja10. V metodi Main uporabnika vprašajte za
vnos treh celih števil, ki jih shranite v spremenljivke a, b in c. Testirajte ali lahko te tri
spremenljivke določajo stranice trikotnika (veljati mora trikotniško pravilo a+b>c in hkrati
a+c>b in b+c>a). Če a, b in c določajo trikotnik, izpišite »So stranice trikotnika«, sicer izpišite
»Niso stranice trikotnika«. Primer: Uporabnik vnese 1,1,3 izpiše se »Niso stranice trikotnika«.
*/
namespace VajaIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aa = Console.ReadLine();
            string bb = Console.ReadLine();
            string cc = Console.ReadLine();

            int a = int.Parse(aa);
            int b = int.Parse(bb);
            int c = int.Parse(cc);

            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("a: " + a + " b: " + b + " c. " + c);
                Console.WriteLine("So stranice trikotnika");
            }
            else
            {
                Console.WriteLine("Niso stranice trikotnika");

            }
        }
    }
}
