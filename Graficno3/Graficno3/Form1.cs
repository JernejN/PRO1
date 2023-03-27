using System;
using System.Windows.Forms;

namespace Graficno3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void BarvaB_Click(object sender, EventArgs e)
        {
            DialogResult odg = DBarva.ShowDialog();
            if (odg == DialogResult.OK)
            {
                textBox1.ForeColor = DBarva.Color;
            }
        }

        private void FontB_Click(object sender, EventArgs e)
        {
            DialogResult font = DFont.ShowDialog();
            if (font == DialogResult.OK)
            {
                textBox1.Font = DFont.Font;
            }
        }
    }
}
