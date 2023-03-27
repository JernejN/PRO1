namespace VajaAbstrakt
{
    internal class Motor : Vozilo, IDrivable
    {
        int stkoles, nhitrost;

        public int Stkoles { get => stkoles; set => stkoles = value; }
        public int Nhitrost { get => nhitrost; set => nhitrost = value; }

        public double drive(int stkm)
        {
            return stkm * 3 / 100.0;
        }
    }
}
