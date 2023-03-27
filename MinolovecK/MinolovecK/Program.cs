using System;

namespace MinolovecK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[,] mine = new bool[10 + 2, 10 + 2];
            Random r = new Random();
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    mine[i, j] = r.NextDouble() < 0.25;
                    if (mine[i, j] == true)
                    {
                        Console.Write("x ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();

            }
            int[,] res = new int[10 + 2, 10 + 2];
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    for (int x = i - 1; x <= i + 1; x++)
                    {
                        for (int y = j - 1; y <= j + 1; y++)
                        {
                            if (mine[x, y] == true)
                            {
                                res[i, j]++;
                            }
                        }
                    }
                }


            }
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (mine[i, j] == true)
                    {
                        Console.Write("{0,2:d}", "x");
                    }
                    else
                    {
                        Console.Write("{0,2:d}", res[i, j]);
                    }

                }
                Console.WriteLine();


            }
            Console.ReadLine();
        }
    }
}
