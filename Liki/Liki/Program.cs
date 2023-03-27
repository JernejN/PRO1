using System;

namespace Liki
{
    class Krog
    {
        protected int x;
        protected int y;
        protected uint r;
        protected int X
        {
            get { return x; }
            set { x = value; }
        }
        protected int Y
        {
            get { return y; }
            set { y = value; }
        }
        protected uint R
        {
            get { return r; }
            set { r = value; }
        }
        public Krog(int xK, int yK, uint rK)
        {
            x = xK;
            y = yK;
            r = rK;
        }
        public int Premer()
        {
            return (int)(2 * r);
        }
        public double Ploščina()
        {
            return (double)(Math.PI * (r * r));
        }

    }
    class Valj : Krog
    {
        protected int v;

        public Valj(int vV)
        {
            v = vV;
        }
        public double Površina()
        {
            return (double)(2 * Math.PI * (r * (r + v)));
        }
        public double Prostornina()
        {
            return (double)(Math.PI * (r * r) * v);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Krog krog1 = new Krog(2, 5, 3);
            Valj valj1 = new Valj(5);
            //int pr = krog1.Premer();
            //double pl = krog1.Ploščina();
            double pr = valj1.Ploščina();
            double pl = valj1.Površina();
            Console.WriteLine("Premer kroga je " + pr + " Ploščina pa " + pl);
        }
    }
}
