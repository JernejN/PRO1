using System;
using System.Windows.Forms;

namespace LikiApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void IzracunKvadrat_Click(object sender, EventArgs e)
        {
            int a = int.Parse(Stranicatxt.Text);
            int obkva = 4 * a;
            int plkva = a * a;
            ObKvadratatxt.Text = obkva + "";
            PlKvadrattxt.Text = plkva + "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void IzracunajKrog_Click(object sender, EventArgs e)
        {
            double r = double.Parse(Stranicatxt.Text);
            double obkrog = 2 * Math.PI * r;
            double plkrog = Math.PI * (r * r);
            ObKrogtxt.Text = obkrog + "";
            PlKrogtxt.Text = plkrog + "";
        }
    }
}
