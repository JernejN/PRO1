using System;

namespace ConsoleApp1_AL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            Console.WriteLine("Vpisi stevila");
            int max, min;
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }



        }
    }
}
