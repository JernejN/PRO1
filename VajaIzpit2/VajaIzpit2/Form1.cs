using System;
using System.Windows.Forms;

namespace VajaIzpit2
{
    public partial class Form1 : Form
    {
        Knjiga[] knjige = new Knjiga[6];
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            knjige[0] = new Knjiga();
            knjige[0].Ime1 = "Na Klancu";
            knjige[0].Avtor1 = "Ivan Cankar";
            knjige[0].Cena = 10.0;
            knjige[1] = new Knjiga();
            knjige[1].Ime1 = "xyz";
            knjige[1].Avtor1 = "Ivan";
            knjige[1].Cena = 13.2;
            knjige[2] = new Knjiga();
            knjige[2].Ime1 = "Antigona";
            knjige[2].Avtor1 = "Sofokles";
            knjige[2].Cena = 15.7;
            listBox1.Items.Clear();
            for (int k = 0; k < 3; k++)
            {
                listBox1.Items.Add(knjige[k]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems != null)
            {
                string Izbrana = listBox1.SelectedItem.ToString();
                for (int k = 0; k < 3; k++)
                {
                    if (Izbrana == knjige[k].Ime1)
                    {
                        MessageBox.Show("Izbral si " + Izbrana +
                            "\n Avtor " + knjige[k].Avtor1 +
                            "\n Cena " + knjige[k].Cena);
                        break;
                    }
                }

            }
        }
    }
}
