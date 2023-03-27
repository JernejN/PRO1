using System;

namespace VajaAbstrakt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Avto a = new Avto();
            a.Stvrat = 5;
            a.Barva = "Rdeča";
            a.Pro = "Alfa romeo";
            a.Model = "Đulijeta";
            a.Leto = 2023;
            Console.WriteLine("Avto********");
            Console.WriteLine("Proizvajalec " + a.Pro);
            Console.WriteLine("Model        " + a.Model);
            Console.WriteLine("Leto         " + a.Leto);
            Console.WriteLine("Za 30 km porabiš " + a.drive(30) + " litrov");

            Motor m = new Motor();
            m.Barva = "Črna";
            m.Pro = "/";
            m.Model = "/";
            m.Leto = 2020;
            m.Nhitrost = 200;
            m.Stkoles = 2;
            Console.WriteLine("Motor********");
            Console.WriteLine("Proizvajalec " + m.Pro);
            Console.WriteLine("Model        " + m.Model);
            Console.WriteLine("Leto         " + m.Leto);
            Console.WriteLine("Za 30 km porabiš " + m.drive(30) + " litrov");

            Tovornjak t = new Tovornjak();
            t.Barva = "Bela";
            t.Pro = "/";
            t.Model = "/";
            t.Leto = 2010;
            t.Nosilnost = 10;
            t.Vlzmogljivost = 3;
            Console.WriteLine("Tovornjak********");
            Console.WriteLine("Proizvajalec " + t.Pro);
            Console.WriteLine("Model        " + t.Model);
            Console.WriteLine("Leto         " + t.Leto);
            Console.WriteLine("Za 30 km porabiš " + t.drive(30) + " litrov");
            Console.ReadLine();
        }
    }
}
