namespace VajaAbstraktK
{
    internal class Knjiga : AbstractProduct
    {
        public Knjiga(int i, string im, double c)
        {
            ID = i;
            Ime = im;
            Cena = c;
        }
        public override string GetDescription()
        {
            return "To je eden on primerov knjige";
        }

        public override double GetDiscountedPrice()
        {
            return Cena * 0.9;
        }
    }
}
