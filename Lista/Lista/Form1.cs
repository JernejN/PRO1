using System;
using System.Windows.Forms;

namespace Lista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gb_tečaji_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_izračun_Click(object sender, EventArgs e)
        {
            double vnos = double.Parse(textBox1.Text);
            if (radioButton1.Checked == true)
            {
                textBox2.Text = (vnos * 1.094).ToString();
                lbl_izpis.Text = "USD";
            }
            if (radioButton2.Checked == true)
            {
                textBox2.Text = (vnos * 0.992).ToString();
                lbl_izpis.Text = "CHF";
            }
            if (radioButton3.Checked == true)
            {
                textBox2.Text = (vnos * 0.88).ToString();
                lbl_izpis.Text = "GBP";
            }
        }

        private void btn_počisti_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            radioButton1.Checked = true;
            lbl_izpis.Text = "";
        }

        private void btn_izhod_Click(object sender, EventArgs e)
        {

        }
    }
}
