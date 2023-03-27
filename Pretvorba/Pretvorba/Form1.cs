using System;
using System.Windows.Forms;

namespace Pretvorba
{
    /*
     * 1EUR = 1,2810 USD
       1EUR = 159,1828 JPY
       1 EUR = 0,6644 GBP

     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Izracunaj_Click(object sender, EventArgs e)
        {
            int eur = int.Parse(Vnostxt.Text);
            if (JPYB.Checked)
            {
                double j = eur * 159.1828;
                Rezultat.Text = j + "";
            }
            else if (GBPB.Checked)
            {
                double g = eur * 0.6644;
                Rezultat.Text = g + "";
            }
            else if (USDB.Checked)
            {
                double u = eur * 1.2810;
                Rezultat.Text = u + "";
            }

        }

        private void JPYB_CheckedChanged(object sender, EventArgs e)
        {
            Sprem.Text = "JPY";

        }

        private void GBPB_CheckedChanged(object sender, EventArgs e)
        {

            Sprem.Text = "GBP";
        }

        private void USDB_CheckedChanged(object sender, EventArgs e)
        {

            Sprem.Text = "USD";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void Pocisti_Click(object sender, EventArgs e)
        {
            Rezultat.Text = "";
            Vnostxt.Text = "";
        }
    }
}
