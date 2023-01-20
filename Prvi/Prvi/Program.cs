namespace Prvi
{
    class Program
    {

        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 101);
            int ugib = 0;

            for (int i = 1; i == 0; i++)
            {
                Console.WriteLine("Ugani število");
                int guess = int.Parse(Console.ReadLine());

                if (guess > num)
                {
                    Console.WriteLine("število, ki ga iščeš je manjše...");
                    ugib++;
                }
                else if (guess < num)
                {
                    Console.WriteLine("število, ki ga iščeš je večje...");
                    ugib++;
                }
                else
                {
                    ugib++;
                    Console.WriteLine("bravo, uganil si v " + ugib + "poskusih!");
                }
            }
        }
    }
}
