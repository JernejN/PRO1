using System;
using System.Windows.Forms;

namespace Pretvornik
{
    public partial class Pretvornik : Form
    {
        public Pretvornik()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_pretvori_Click(object sender, EventArgs e)
        {
            int d = int.Parse(txt_vnos.Text), i;

            int[] tab = new int[10];
            for (i = 0; d > 0; i++)
            {
                tab[i] = d % 2;
                d = d / 2;
            }
            String odg = "";
            for (i = i - 1; i >= 0; i--)
            {
                odg += tab[i];
            }
            txt_vnos.Text = odg;
        }

        private void txt_clean_Click(object sender, EventArgs e)
        {
            txt_vnos.Text = "";
        }
    }
}
