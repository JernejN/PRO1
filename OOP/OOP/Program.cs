using System;

namespace OOP
{
    public class MojR
    {
        private String mojNiz;

        //Setter
        public MojR(string niz)
        {
            mojNiz = niz;
        }

        public void izpis()
        {
            Console.WriteLine(mojNiz);
        }

        static void Main(string[] args)
        {
            MojR prvi; //objekt
            prvi = new MojR("Moj prvi objekt v C#");
            prvi.izpis();
        }
    }
}
