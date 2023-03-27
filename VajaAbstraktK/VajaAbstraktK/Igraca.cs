namespace VajaAbstraktK
{
    internal class Igraca : AbstractProduct
    {
        public Igraca(int i, string im, double c)
        {
            ID = i;
            Ime = im;
            Cena = c;
        }
        public override string GetDescription()
        {
            return "To je eden on primerov igrače";
        }

        public override double GetDiscountedPrice()
        {
            return Cena * 0.5;
        }
    }
}
