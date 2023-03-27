namespace VajaLiki
{
    internal class Kvader : Pravokotnik
    {
        int v;
        public Kvader(int x1p, int y1p, int x2p, int y2p, int vp) : base(x1p, y1p, x2p, y2p)
        {
            v = vp;

        }
        public int prostornina()
        {
            return Ploscina() * v;
        }
        public int povrsina()
        {
            return 2 * Ploscina() +
                   2 * StranicaA() * v +
                   2 * StranicaB() * v;
        }
    }
}
