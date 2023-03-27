namespace VajaRazrediD1
{
    internal class Oseba
    {
        string ime;
        int st;

        public string Ime { get => ime; set => ime = value; }
        public int St { get => st; set => st = value; }

        public Oseba(string i, int s)
        {
            ime = i;
            st = s;


        }
        public int GetAgeInMonths(int st)
        {
            int a = st * 12;
            return a;
        }

        public bool IsEqual(Oseba x)
        {
            if (ime == x.ime && st == x.st)
            {
                return true;
            }
            return false;
        }

        public bool IsAdult(int st)
        {
            if (st > 18)
            {
                return true;
            }
            else
            {
                return true;

            }
        }
    }
}
