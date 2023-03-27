using System;

namespace VajaRazrediD2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pravokotnik c = new Pravokotnik(3, 4);
            Pravokotnik e = new Pravokotnik(2, 2);
            Console.WriteLine("površina c: " + c.GetArea());
            Console.WriteLine("obseg c: " + c.GetPerimeter());
            Console.WriteLine("Ali je e kvadrat? " + e.IsSquare());
            Console.ReadLine();
        }
    }
}
