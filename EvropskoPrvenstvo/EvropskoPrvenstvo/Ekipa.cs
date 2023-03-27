using System;

namespace EvropskoPrvenstvo
{
    internal class Ekipa
    {
        string ime;
        int stTekem, stzmag, stNeodlocenih, daniGoli, prejetiGoli;
        public Ekipa(string i)
        {
            ime = i;
            stTekem = 0; stzmag = 0; stNeodlocenih = 0; daniGoli = 0; prejetiGoli = 0;
        }
        public void VnesiRezultat(int d, int p)
        {
            stTekem++;
            if (d > p)
            {
                stzmag++;
            }
            else if (d == p)
            {
                stNeodlocenih++;
            }
            daniGoli += d;
            prejetiGoli += p;
        }

        public int StTock()
        {
            return 3 * stzmag + stNeodlocenih;
        }
        public int GolRazlika()
        {
            return daniGoli - prejetiGoli;
        }
        public void Izpis()
        {
            Console.WriteLine(Ime + "\t" + StTock() + "\t" + GolRazlika() + "\t" + daniGoli);

        }
        public bool BoljsaEkipa(Ekipa druga)
        {
            if (this.StTock() > druga.StTock())
            {
                return true;
            }
            if (this.StTock() == druga.StTock() && this.GolRazlika() > druga.GolRazlika())
            {
                return true;
            }
            if (this.StTock() == druga.StTock() && this.GolRazlika() == druga.GolRazlika() && this.daniGoli > druga.daniGoli)
            {
                return true;
            }
            return false;
        }

        public string Ime { get => ime; set => ime = value; }
        public int StTekem { get => stTekem; set => stTekem = value; }
        public int Stzmag { get => stzmag; set => stzmag = value; }
        public int StNeodlocenih { get => stNeodlocenih; set => stNeodlocenih = value; }
        public int DaniGoli { get => daniGoli; set => daniGoli = value; }
        public int PrejetiGoli { get => prejetiGoli; set => prejetiGoli = value; }
    }
}
