using System;
/*
 * Napiši program, ki izračuna in izpiše vsoto S= sin(π/1)+ sin(π/2)+ sin(π/3)+ ….+sin(π/100)
 */
namespace VajaZanke7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double v = 0;
            for (int i = 1; i < 100; i++)
            {
                v = v + Math.Sin(Math.PI / i);
            }
            Console.WriteLine("Vsota: " + v);
            Console.ReadLine();
        }
    }
}
