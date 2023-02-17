using System;

namespace VajaPostvanka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            bool odg = false;


            int o = 0;
            int p = 0;
            string ponovno = "";

            do
            {
                Console.WriteLine("Izberi stevilo");
                int x = int.Parse(Console.ReadLine());
                for (int i = 1; i <= 5; i++)
                {
                    int y = r.Next(9);
                    Console.WriteLine(y + "*" + x + "=?");
                    o = int.Parse(Console.ReadLine());
                    if (o == x * y)
                    {
                        p++;
                    }
                }
                Console.WriteLine("Pravilo ste odgovorili " + p + "/5 odgovorov");
                Console.WriteLine("Ali želite ponovno igrati ponovno?");
                ponovno = Console.ReadLine();
                p = 0;
                odg = false;
                if (ponovno.Equals("ja"))
                {
                    odg = true;
                }

            } while (odg == true);

        }
    }
}
