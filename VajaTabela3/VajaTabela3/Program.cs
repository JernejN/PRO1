using System;

namespace VajaTabela3
{

    /*
    Napišite program, v katerem imate deklarirano dvodimenzionalno tabelo c, ki
    vsebuje 5X5 malih črk. Tabelo napolnite z naključnimi malimi črkami. Izpišite
    jo v obliki 5 vrstic in 5 stolpcev. Poiščite črko v tabeli, ki je po abecedi
    najmanjša. Upoštevajte, da je ASCII koda 'a' = 97.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] c = new char[5, 5];
            Random r = new Random();
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    c[i, j] = (char)(r.Next(26) + 'a');
                }
            }

            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    Console.Write(c[i, j] + " ");
                }
                Console.WriteLine();
            }
            char min = 'z';
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    if (c[i, j] < min)
                    {
                        min = c[i, j];
                    }
                }
            }
            Console.WriteLine("min: " + min);
            Console.ReadLine();

        }
    }
}
