namespace VajaAbstrakt
{
    internal abstract class Vozilo
    {
        protected string pro, model, barva;
        protected int leto;

        public string Pro { get => pro; set => pro = value; }
        public string Model { get => model; set => model = value; }
        public string Barva { get => barva; set => barva = value; }
        public int Leto { get => leto; set => leto = value; }


    }
}
