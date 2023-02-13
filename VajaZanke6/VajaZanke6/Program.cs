using System;
/*
 Napiši program, ki izpiše vse črke (velike in male) in njihove ASCII kode. V vsaki vrstici naj bo
po 10 črk.
 */
namespace VajaZanke6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int k = (int)'A'; k <= (int)'Z'; k++)
            {
                char s = (char)k;
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(s);
                }
                Console.WriteLine(" " + k);
            }

            Console.ReadLine();

        }
    }
}
