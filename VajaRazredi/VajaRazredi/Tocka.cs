using System;

namespace VajaRazredi
{
    internal class Tocka
    {
        double x, y, r;
        int kot;
        public void PretvorivP()
        {
            r = Math.Sqrt(x * x + y * y);
            kot = (int)(Math.Atan(y / x) * 180(Math.PI));
        }
        public void PretvorivK()
        {
            x = r * Math.Cos(kot * Math.PI / 180);
            y = r * Math.Sin(kot * Math.PI / 180);
        }
        public Tocka()
        {
            x = 0;
            y = 0;
            PretvorivP();
        }
        public Tocka(double x1, double y1)
        {
            x = x1;
            y = y1;
            PretvorivK();
        }
        public Tocka(double r1, int kot1)
        {
            r = r1;
            kot = kot1;
            PretvorivK();

        }
        public izpis()
        {
            Console.WriteLine("**********Točka**********");
            Console.WriteLine("kartezične: (" + x + "," + y + ")");
            Console.WriteLine("Polarne: (" + r + "," + kot + "°)");
        }
    }
}
