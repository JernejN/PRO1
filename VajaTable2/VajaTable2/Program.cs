using System;

namespace VajaTable2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] b = new int[10, 10];
            Random r = new Random();
            int max = 0;
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    b[i, j] = r.Next(100);
                }
            }

            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write("{0,5:d}", b[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    if (max < b[i, j])
                    {
                        max = b[i, j];
                    }
                }
            }
            int v = 0;
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    v = v + b[i, j];
                }
            }
            Console.WriteLine("----------DIAG----------");
            //for (int i = 0; i < b.GetLength(0); i++)
            //{
            //    for (int j = 0; j < b.GetLength(1); j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.WriteLine(b[i, j] + " ");
            //        }
            //    }
            //}

            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write("{0,5:d}", b[i, j] + " ");
                    }
                    else
                    {
                        Console.Write("{0,2:d}", "  ");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------");

            Console.WriteLine("max: " + max);
            Console.WriteLine("Vsota: " + v);
            Console.ReadLine();


        }
    }
}
