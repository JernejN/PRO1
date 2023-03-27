using System;

namespace VajaLiki
{
    internal class Valj : Krog
    {
        double vi;
        public Valj(int xk, int yk, double rk, double vk) : base(xk, yk, rk)
        {
            vi = vk;
        }

        public double Vi { get => vi; set => vi = value; }

        public double površina()
        {
            return 2 * ploscinaK() +
                    2 * Math.PI * R * vi;
        }
        public double volumen()
        {
            return ploscinaK() * vi;
        }
    }
}
