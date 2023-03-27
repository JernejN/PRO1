using System;

namespace VajaLiki
{
    internal class Krog
    {
        int x, y;
        double r;
        public Krog(int xk, int yk, double rk)
        {
            x = xk;
            y = yk;
            r = rk;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public double R { get => r; set => r = value; }

        public double premer()
        {
            return r * 2;
        }
        public double ploscinaK()
        {
            return Math.PI * Math.Sqrt(r);
        }
    }
}
