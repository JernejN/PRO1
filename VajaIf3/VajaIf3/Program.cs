using System;
/*
 *Izdelajte novo konzolno aplikacijo. Najprej uporabnika vprašajte naj vnese temperaturo vode
(število od 5 do 100). Glede na vneseno temperaturo izpiše:
a. če je t<=10 »zelo mrzla«
b. če je 10<t<=20 »hladna«
c. če je 20<t<=30 »topla«
d. če je 30<t<=50 »vroča«
e. če je t<50 »zelo vroča«
 */
namespace VajaIf3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int b = int.Parse(a);

            if (b <= 10)
            {
                Console.WriteLine("Zelo mrzla");
            }
            else if (10 < b && b <= 20)
            {
                Console.WriteLine("Hladna");
            }
            else if (20 < b && b <= 30)
            {
                Console.WriteLine("topla");
            }
            else if (30 < b && b <= 40)
            {
                Console.WriteLine("vroča");
            }
            else if (b < 50)
            {
                Console.WriteLine("Zelo vroča");
            }

        }
    }
}
