namespace VajaAbstrakt
{
    internal class Tovornjak : Vozilo, IDrivable
    {
        int nosilnost, vlzmogljivost;

        public int Nosilnost { get => nosilnost; set => nosilnost = value; }
        public int Vlzmogljivost { get => vlzmogljivost; set => vlzmogljivost = value; }

        public double drive(int stkm)
        {
            return stkm * 15 / 100.0;
        }
    }
}
