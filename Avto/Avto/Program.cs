using System;

namespace Avto
{
    public class Avto
    {
        double maxHitrost, avgPoraba, gorivo, km;
        string reg;

        /* konstruktor 1*/
        public Avto(double maxHitrost, double avgPoraba, double km)
        {
            this.maxHitrost = maxHitrost;
            this.avgPoraba = avgPoraba;
            this.gorivo = gorivo;
            km = 0;
            reg = "/";
        }
        /* konstruktor 2 */
        public Avto(double maxHitrost, double avgPoraba, double gorivo, double km, string reg)
        {

            this.maxHitrost = maxHitrost;
            this.avgPoraba = avgPoraba;
            this.gorivo = gorivo;
            this.km = km;
            this.reg = reg;
        }

        public void izpisiVse()
        {
            Console.WriteLine("Maksimalna hitrost: " + maxHitrost);
            Console.WriteLine("Poraba: " + avgPoraba);
            Console.WriteLine("Gorivo: " + gorivo);
            Console.WriteLine("kilometri: " + km);
            Console.WriteLine("Registerska: " + reg);
        }
        public double doseg()
        {
            return (gorivo / avgPoraba * 100.0);
        }

        public double naslednjiServis(int n)
        {
            return km - n;
        }

        static void Main(string[] args)
        {

            Avto a1 = new Avto(165, 6.8, 0);
            a1.izpisiVse();
            Console.WriteLine();

            Avto Toyota = new Avto(200, 7.25, 28.9, 87345.0, "LJ A1-123");
            Toyota.izpisiVse();
            Console.WriteLine("Nalednji servis Toyote pri: " + Toyota.naslednjiServis(15000));
            Console.WriteLine("toyota lahko prevozi še: " + Toyota.doseg());
        }
    }
}
