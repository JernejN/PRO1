namespace VajaAbstrakt
{
    internal class Avto : Vozilo, IDrivable
    {
        int stvrat, velprtljaznika;

        public int Stvrat { get => stvrat; set => stvrat = value; }
        public int Velprtljaznika { get => velprtljaznika; set => velprtljaznika = value; }

        public double drive(int stkm)
        {
            return stkm * 6 / 100.0;
        }
    }
}
