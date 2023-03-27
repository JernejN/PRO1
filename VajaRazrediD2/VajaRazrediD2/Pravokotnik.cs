namespace VajaRazrediD2
{
    internal class Pravokotnik
    {
        int d;
        int s;
        public Pravokotnik(int a, int b)
        {
            d = a;
            s = b;
        }

        public int S { get => s; set => s = value; }
        public int D { get => d; set => d = value; }

        public double GetArea()
        {
            double area = d * s;
            return area;
        }

        public double GetPerimeter()
        {
            double perimeter = 2 * d + 2 * s;
            return perimeter;

        }

        public bool IsSquare()
        {
            if (s == d)
            {
                return true;
            }
            return false;

        }
    }
}
