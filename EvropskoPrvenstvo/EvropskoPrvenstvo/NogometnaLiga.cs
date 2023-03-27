using System;

namespace EvropskoPrvenstvo
{
    internal class NogometnaLiga
    {
        Ekipa[] Liga = new Ekipa[10];
        int[,] pari = new int[10, 10];
        public NogometnaLiga()
        {
            Liga[0] = new Ekipa("Slovenija");
            Liga[1] = new Ekipa("Italija  ");
            Liga[2] = new Ekipa("Poljska  ");
            Liga[3] = new Ekipa("Švica    ");
            Liga[4] = new Ekipa("Isladija ");
            Liga[5] = new Ekipa("Nemčija  ");
            Liga[6] = new Ekipa("Španija  ");
            Liga[7] = new Ekipa("Grčija   ");
            Liga[8] = new Ekipa("Avstrija ");
            Liga[9] = new Ekipa("Hrvaška  ");
            IzdelajTurnir();
        }
        public void IzpisiTurnir()
        {
            for (int kolo = 1; kolo <= 9; kolo++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int z = 0; z < 10; z++)
                    {
                        if (pari[j, z] == kolo)
                        {
                            Ekipa prva = Liga[j];
                            Ekipa druga = Liga[z];
                            Console.WriteLine(prva.Ime + " : " + druga.Ime);
                        }
                    }
                }
            }

            int x = 0;
            int y = 1;
            int[] zgoraj = { 2, 3, 4, 5 };
            int[] spodaj = { 9, 8, 7, 6 };
            public void NapolniPare(int kolo)
            {
                pari[x, y] = kolo;
                pari[zgoraj[0], spodaj[0]] = kolo;
                pari[zgoraj[1], spodaj[1]] = kolo;
                pari[zgoraj[2], spodaj[2]] = kolo;
                pari[zgoraj[3], spodaj[3]] = kolo;
                int temp = y;
                y = spodaj[0];
                spodaj[0] = spodaj[1];
                spodaj[1] = spodaj[2];
                spodaj[2] = spodaj[3];
                spodaj[3] = zgoraj[3];
                zgoraj[3] = zgoraj[2];
                zgoraj[2] = zgoraj[1];
                zgoraj[1] = zgoraj[0];
                zgoraj[0] = temp;
            }
            public void IzdelajTurnir()
            {
                for (int i = 1; i <= 9; i++)
                {
                    NapolniPare(i);
                }
            }

        }
    }
}

