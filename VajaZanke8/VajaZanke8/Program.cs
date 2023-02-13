using System;
/*
 Izračunaj vrednost izraza 1+ x/1 + x2/(1*2) + x3/(1*2*3) + x4/(1*2*3*4)*…. na 5 decimalnih mest natančno. X je podatek, ki ga bereš prek tipkovnice
 */
namespace VajaZanke8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double v = 1;
            double c = 1;
            Console.WriteLine("Vnesi vrednost x");
            double x = double.Parse(Console.ReadLine());
            int i = 1;
            //for (int i = 1; i <= 100; i++)
            while (Math.Abs(v - Math.Exp(x)) > 0.000001)
            {
                c = c * x / i;
                v = v + c;
                i++;
            }
            Console.WriteLine("Vsota: " + v);
            Console.WriteLine("e na x: " + Math.Exp(x));
            Console.ReadLine();
        }
    }
}
