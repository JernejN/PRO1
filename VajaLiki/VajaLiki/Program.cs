using System;

namespace VajaLiki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PRAVOKOTNIK");
            Pravokotnik p = new Pravokotnik(0, 1, 1, 0);
            Console.WriteLine("Koordinati kota levo zgoraj = " + p.X1 + "," + p.Y1 +
            "\nKoordinati kota desno spodaj = " + p.X2 + "," + p.Y2);
            Console.WriteLine("Stranica a " + p.StranicaA());
            Console.WriteLine("Stranica b " + p.StranicaB());
            Console.WriteLine("Plošina " + p.Ploscina());

            Console.WriteLine("KROG");
            Krog k = new Krog(37, 45, 2.5f);
            Console.WriteLine("X koordinata = " + k.X +
            "\nY koordinata = " + k.Y +
            "\nRadij =" + k.R);
            Console.WriteLine("Premer = " + k.premer());
            Console.WriteLine("Plošcina =" + k.ploscinaK());
            k.X = 2;
            k.Y = 2;
            k.R = 4.25f;
            Console.WriteLine("Nova pozicija :");
            Console.WriteLine("X koordinata = " + k.X +
            "\nY koordinata = " + k.Y +
            "\nRadij =" + k.R);
            Console.WriteLine("Premer = " + k.premer());
            Console.WriteLine("Plošcina =" + k.ploscinaK());

            Console.WriteLine("KVADER");
            Kvader kv = new Kvader(0, 1, 1, 0, 1);
            Console.WriteLine("Prostornina: " + kv.prostornina());
            Console.WriteLine("Površina: " + kv.povrsina());
            Console.WriteLine("VALJ");
            Valj v = new Valj(37, 45, 2.5f, 1f);
            Console.WriteLine("X koordinata = " + v.X +
            "\nY koordinata = " + v.Y +
            "\nRadij =" + v.R +
            "\nVišina =" + v.Vi);
            Console.WriteLine("Površina = " + v.površina());
            Console.WriteLine("Volumen =" + v.volumen());
            Console.ReadLine();
        }
    }
}
