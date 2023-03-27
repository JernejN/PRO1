namespace VajaAbstraktK
{
    internal abstract class AbstractProduct : IProduct
    {
        protected int ID;
        protected string Ime;
        protected double Cena;
        public int GetID()
        {
            return ID;
        }

        public string GetIme()
        {
            return Ime;
        }

        public double GetPrice()
        {
            return Cena;
        }
        public abstract string GetDescription();
        public abstract double GetDiscountedPrice();
        public string GetCategory()
        {
            if (this is Igraca)
            {
                return "Kategorija: Igraca";
            }
            return "Kategorija:Knjiga";
        }
    }
}
