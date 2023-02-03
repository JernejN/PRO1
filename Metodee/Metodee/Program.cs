using System;

namespace Metodee
{
    class metode
    {
        static void Main(string[] args)
        {
            double r = 0;
            Console.WriteLine("Vnesit vrednost in znak za operacijo");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Vrednot a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Vrednot a: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Željena operacija (+,-,*,/) : ");
            String op = (Console.ReadLine());

            switch (op)
            {
                case "*":
                    r = mnozi(a, b);
                    break;
                case "+":
                    r = sestej(a, b);
                    break;
                case "/":
                    r = deli(a, b);
                    break;
                case "-":
                    r = odstej(a, b);
                    break;
            }

            Console.WriteLine("Rezultat je: " + r);
            Console.ReadKey();

        }

        public static double deli(double a, double b)
        {
            return a / b;
        }

        public static double mnozi(double a, double b)
        {
            return a * b;
        }
        public static double sestej(double a, double b)
        {
            return a + b;
        }
        public static double odstej(double a, double b)
        {
            return a - b;
        }


    }
}
